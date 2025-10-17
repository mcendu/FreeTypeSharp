namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_ColorStop_
    {
        public CLong stop_offset;
        public FT_ColorIndex_ color;
    }
}