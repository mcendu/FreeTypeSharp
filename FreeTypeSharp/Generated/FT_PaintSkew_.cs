namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintSkew_
    {
        public FT_Opaque_Paint_ @paint;
        public CLong @x_skew_angle;
        public CLong @y_skew_angle;
        public CLong @center_x;
        public CLong @center_y;
    }
}