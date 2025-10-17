namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintScale_
    {
        public FT_Opaque_Paint_ @paint;
        public CLong @scale_x;
        public CLong @scale_y;
        public CLong @center_x;
        public CLong @center_y;
    }
}