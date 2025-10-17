namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintComposite_
    {
        public FT_Opaque_Paint_ source_paint;
        public FT_Composite_Mode_ composite_mode;
        public FT_Opaque_Paint_ backdrop_paint;
    }
}