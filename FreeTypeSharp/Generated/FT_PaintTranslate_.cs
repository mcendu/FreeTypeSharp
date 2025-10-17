namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintTranslate_
    {
        public FT_Opaque_Paint_ paint;
        public CLong dx;
        public CLong dy;
    }
}