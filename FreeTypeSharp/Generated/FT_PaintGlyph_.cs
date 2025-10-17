namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintGlyph_
    {
        public FT_Opaque_Paint_ paint;
        public uint glyphID;
    }
}