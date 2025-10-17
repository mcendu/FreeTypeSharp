namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_ColorLine_
    {
        public FT_PaintExtend_ extend;
        public FT_ColorStopIterator_ color_stop_iterator;
    }
}