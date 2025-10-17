namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintRadialGradient_
    {
        public FT_ColorLine_ colorline;
        public FT_Vector_ c0;
        public CLong r0;
        public FT_Vector_ c1;
        public CLong r1;
    }
}