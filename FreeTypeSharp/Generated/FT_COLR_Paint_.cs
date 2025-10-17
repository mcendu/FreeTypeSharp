namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_COLR_Paint_
    {
        public FT_PaintFormat_ format;
        public Anonymous__FT_COLR_Paint__u u;
    }
}