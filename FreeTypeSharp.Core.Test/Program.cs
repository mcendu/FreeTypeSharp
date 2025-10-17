using System;
using static FreeTypeSharp.FT;

namespace FreeTypeSharp.Core.Test
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            FT_LibraryRec_* library;

            var error = FT_Init_FreeType(&library);
            int major, minor, patch;
            FT_Library_Version(library, &major, &minor, &patch);
            Console.WriteLine($"FreeType version: {major}.{minor}.{patch}");
        }
    }
}
