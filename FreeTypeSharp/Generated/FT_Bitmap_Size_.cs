namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Bitmap_Size_
    {
        public short @height;
        public short @width;
        public CLong @size;
        public CLong @x_ppem;
        public CLong @y_ppem;
    }
}