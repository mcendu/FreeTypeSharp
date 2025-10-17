namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintLinearGradient_
    {
        public FT_ColorLine_ @colorline;
        public FT_Vector_ @p0;
        public FT_Vector_ @p1;
        public FT_Vector_ @p2;
    }
}