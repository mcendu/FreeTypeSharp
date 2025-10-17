namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintTransform_
    {
        public FT_Opaque_Paint_ paint;
        public FT_Affine_23_ affine;
    }
}