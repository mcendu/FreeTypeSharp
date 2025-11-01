// SPDX-License-Identifier: MIT
#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using CppSharp.AST;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using ArraySize = CppSharp.AST.ArrayType.ArraySize;

namespace FreeTypeSharp.Generator
{
  public static class Walker
  {
    private static IReadOnlyDictionary<PrimitiveType, TypeSyntax> builtinTypeTranslations
      = new Dictionary<PrimitiveType, TypeSyntax>
      {
        { PrimitiveType.Void, PredefinedType(Token(SyntaxKind.VoidKeyword)) },
        { PrimitiveType.Bool, PredefinedType(Token(SyntaxKind.BoolKeyword)) },
        { PrimitiveType.Char, PredefinedType(Token(SyntaxKind.ByteKeyword)) },
        { PrimitiveType.SChar, PredefinedType(Token(SyntaxKind.SByteKeyword)) },
        { PrimitiveType.Short, PredefinedType(Token(SyntaxKind.ShortKeyword)) },
        { PrimitiveType.Int, PredefinedType(Token(SyntaxKind.IntKeyword)) },
        { PrimitiveType.Long, IdentifierName("CLong") },
        { PrimitiveType.LongLong, PredefinedType(Token(SyntaxKind.LongKeyword)) },
        { PrimitiveType.UChar, PredefinedType(Token(SyntaxKind.ByteKeyword)) },
        { PrimitiveType.UShort, PredefinedType(Token(SyntaxKind.UShortKeyword)) },
        { PrimitiveType.UInt, PredefinedType(Token(SyntaxKind.UIntKeyword)) },
        { PrimitiveType.ULong, IdentifierName("CULong") },
        { PrimitiveType.ULongLong, PredefinedType(Token(SyntaxKind.ULongKeyword)) },
        { PrimitiveType.Float, PredefinedType(Token(SyntaxKind.FloatKeyword)) },
        { PrimitiveType.Double, PredefinedType(Token(SyntaxKind.DoubleKeyword)) },
      };

    private static string nestedStructName(string field, int nestLevel)
        => $@"InnerStruct_{field}_{nestLevel}";

    private static TypeSyntax translateFieldType(
        CppSharp.AST.Type type, string field, int nestLevel = 0)
    {
      if (type is BuiltinType builtinType)
      {
        return builtinTypeTranslations[builtinType.Type];
      }

      if (type is PointerType pointerType)
      {
        if (pointerType.Pointee is FunctionType functionType)
        {
          return FunctionPointerType(
            FunctionPointerCallingConvention(
              Token(SyntaxKind.UnmanagedKeyword)),
              FunctionPointerParameterList().AddParameters(
                functionType.Parameters
                  .Select((param) => FunctionPointerParameter(
                    translateFieldType(
                      param.Type,
                      $@"{field}_{nestLevel}_{param.DefinitionOrder}",
                      0)))
                  .Append(FunctionPointerParameter(
                    translateFieldType(
                      functionType.ReturnType.Type,
                      $@"{field}_{nestLevel}_return",
                      0)))
                  .ToArray()));
        }

        return PointerType(translateFieldType(pointerType.Pointee, field, nestLevel + 1));
      }

      if (type is TypedefType typedefType)
      {
        if (typedefType.Declaration.Name == "FT_Error")
          return IdentifierName("FT_Error");

        return translateFieldType(typedefType.Declaration.Type, field, nestLevel + 1);
      }

      if (type is TagType tagType)
      {
        string name = tagType.Declaration.Name;

        return IdentifierName(
            name == string.Empty
                ? nestedStructName(field, nestLevel)
                : name);
      }

      if (type is ArrayType arrayType && arrayType.SizeType == ArraySize.Constant)
      {
        // A nested struct with an InlineArrayAttribute is generated.
        return IdentifierName(nestedStructName(field, nestLevel));
      }

      throw new NotSupportedException();
    }

    private static IEnumerable<MemberDeclarationSyntax> generateNestedStructs(
        CppSharp.AST.Type type, string field, int nestLevel = 0)
    {
      var result = Enumerable.Empty<MemberDeclarationSyntax>();

      if (type is PointerType pointerType)
      {
        result = result.Concat(generateNestedStructs(pointerType.Pointee, field, nestLevel + 1));
      }

      if (type is TypedefType typedefType)
      {
        result = result.Concat(generateNestedStructs(typedefType.Declaration.Type, field, nestLevel + 1));
      }

      if (type is TagType tagType)
      {
        string name = tagType.Declaration.Name;

        if (name == string.Empty && tagType.Declaration is Class @class)
        {
          result = result.Append(translateStruct(@class, nestedStructName(field, nestLevel)));
        }
      }

      if (type is ArrayType arrayType && arrayType.SizeType == ArraySize.Constant)
      {
        // generate a nested [InlineArray] struct with an autoassigned name
        result = result.Append(
          StructDeclaration(
            new SyntaxList<AttributeListSyntax>(new[]
            {
              AttributeList().AddAttributes(
                Attribute(
                  IdentifierName("InlineArray"),
                  AttributeArgumentList().AddArguments(
                    AttributeArgument(LiteralExpression(
                      SyntaxKind.NumericLiteralExpression,
                      Literal((int)arrayType.Size))))))
            }),
            new SyntaxTokenList(Token(SyntaxKind.PublicKeyword)),
            Identifier(nestedStructName(field, nestLevel)),
            default,
            default,
            default,
            new SyntaxList<MemberDeclarationSyntax>(
              FieldDeclaration(
                VariableDeclaration(
                  translateFieldType(arrayType.Type, field, nestLevel)
                ).AddVariables(VariableDeclarator(field)))))
          );

        // recurse to find further nested data structures
        result = result.Concat(generateNestedStructs(arrayType.Type, field, nestLevel));
      }

      if (type is FunctionType functionType)
      {
        result = result.Concat(functionType.Parameters.SelectMany(
            (param) => generateNestedStructs(
                param.Type, $@"{field}_{nestLevel}_{param.DefinitionOrder}", 0)));
      }

      return result;
    }

    private static StructDeclarationSyntax translateStruct(Class @class, string name)
        => StructDeclaration(
            new SyntaxList<AttributeListSyntax>(new[]
            {
              AttributeList().AddAttributes(
                Attribute(
                  IdentifierName("StructLayout"),
                  AttributeArgumentList().AddArguments(
                    AttributeArgument(MemberAccessExpression(
                      SyntaxKind.SimpleMemberAccessExpression,
                      IdentifierName("LayoutKind"),
                      IdentifierName(
                        @class.IsUnion ? "Explicit" : "Sequential"))))))
            }),
            new SyntaxTokenList(
                Token(SyntaxKind.PublicKeyword),
                Token(SyntaxKind.UnsafeKeyword)),
            Identifier(name),
            default,
            default,
            default,
            new SyntaxList<MemberDeclarationSyntax>(@class.Fields.SelectMany(
              (field) => new[] {
                FieldDeclaration(
                    new SyntaxList<AttributeListSyntax>(new[]
                    {
                      AttributeList().AddAttributes(
                        Attribute(
                          IdentifierName("FieldOffset"),
                          AttributeArgumentList().AddArguments(
                            AttributeArgument(LiteralExpression(
                              SyntaxKind.NumericLiteralExpression,
                              Literal(0))))))
                    }.Where(_ => @class.IsUnion)),
                    new SyntaxTokenList(Token(SyntaxKind.PublicKeyword)),
                    VariableDeclaration(
                      translateFieldType(field.Type, field.Name)
                    ).AddVariables(
                      VariableDeclarator(Identifier($@"@{field.Name}"))))
              }.Concat(generateNestedStructs(field.Type, field.Name)))
            ));

    public static CompilationUnitSyntax? TranslateStructToCompilationUnit(Class @class)
    {
      return CompilationUnit(
        default,
        new SyntaxList<UsingDirectiveSyntax>(new[]
        {
          UsingDirective(
            QualifiedName(
              QualifiedName(
                IdentifierName("System"),
                IdentifierName("Runtime")),
              IdentifierName("InteropServices"))),
          UsingDirective(
            QualifiedName(
              QualifiedName(
                IdentifierName("System"),
                IdentifierName("Runtime")),
              IdentifierName("CompilerServices"))),
        }),
        default,
        new SyntaxList<MemberDeclarationSyntax>(new[]
        {
          NamespaceDeclaration(
            IdentifierName("FreeTypeSharp"),
            default,
            default,
            new SyntaxList<MemberDeclarationSyntax>(new[]
            {
              translateStruct(@class, @class.Name)
                .WithLeadingTrivia(new []
                {
                  Comment("/// <remarks>This struct is anonymous.</remarks>"),
                }.Where(_ => @class.IsIncomplete))
            })),
        })).WithLeadingTrivia(
          Comment("// SPDX-License-Identifier: MIT"),
          Comment("// This file is automatically generated."));
    }
  }
}
