namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintSweepGradient_
    {
        public FT_ColorLine_ @colorline;
        public FT_Vector_ @center;
        public CLong @start_angle;
        public CLong @end_angle;
    }
}