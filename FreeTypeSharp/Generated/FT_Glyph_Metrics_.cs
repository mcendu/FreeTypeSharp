namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Glyph_Metrics_
    {
        public CLong @width;
        public CLong @height;
        public CLong @horiBearingX;
        public CLong @horiBearingY;
        public CLong @horiAdvance;
        public CLong @vertBearingX;
        public CLong @vertBearingY;
        public CLong @vertAdvance;
    }
}