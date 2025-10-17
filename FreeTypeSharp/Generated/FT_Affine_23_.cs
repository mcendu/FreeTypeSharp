namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Affine_23_
    {
        public CLong @xx;
        public CLong @xy;
        public CLong @dx;
        public CLong @yx;
        public CLong @yy;
        public CLong @dy;
    }
}