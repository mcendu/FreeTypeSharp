# FreeTypeSharp
[![Nuget](https://img.shields.io/nuget/v/FreeTypeSharp)](https://www.nuget.org/packages/FreeTypeSharp/)

A modern managed FreeType2 library which has source code generated from the original C headers.

FreeTypeSharp v2+ provides cross-platform bindings for:

- netcoreapp3.1;net8.0 (Windows, Linux, macOS)
- net8.0-android
- net8.0-ios
- net8.0-tvos
- netstandard2.0
- net9.0 (UWP)

[README](https://github.com/ryancheung/FreeTypeSharp/tree/v1) for release v1.X

## FreeType Wrapped

FreeType 2.13.2

Native binaries are built by the CI in https://github.com/ryancheung/freetype/tree/csharp-patch

# Installation

`dotnet add package FreeTypeSharp`

UWP target is in a seperate package

`dotnet add package FreeTypeSharp.UWP`

# Usage

There's no magic(abstraction) based on the original C freetype API. All managed API are almost identical with the original freetype C API.  
Import the namespaces like `using FreeTypeSharp;` and `using static FreeTypeSharp.FT;`, then you can play the font rendering as what you do in C.

Here are few sample code:
```csharp
using static FreeTypeSharp.FT;
using static FreeTypeSharp.FT_LOAD;
using static FreeTypeSharp.FT_Render_Mode_;

FT_LibraryRec_* lib;
FT_FaceRec_* face;
var error = FT_Init_FreeType(&lib);

error = FT_New_Face(lib, (byte*)Marshal.StringToHGlobalAnsi("some_font_name.ttf"), 0, &face);
error = FT_Set_Char_Size(face, 0, 16 * 64, 300, 300);
var glyphIndex = FT_Get_Char_Index(face, 'F');
error = FT_Load_Glyph(face, glyphIndex, FT_LOAD_DEFAULT);
error = FT_Render_Glyph(face->glyph, FT_RENDER_MODE_NORMAL);
...
```

More FreeType docs: https://freetype.org/freetype2/docs/documentation.html

# Credits

- https://github.com/tlgkccampbell/ultraviolet
- https://github.com/Robmaister/SharpFont/

Special thanks to https://github.com/tonisimakov99/FreeTypeBinding for source code generator.
