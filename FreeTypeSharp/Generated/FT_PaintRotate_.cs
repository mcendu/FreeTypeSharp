namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintRotate_
    {
        public FT_Opaque_Paint_ paint;
        public CLong angle;
        public CLong center_x;
        public CLong center_y;
    }
}