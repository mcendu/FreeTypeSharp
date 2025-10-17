namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Outline_
    {
        public ushort @n_contours;
        public ushort @n_points;
        public FT_Vector_* @points;
        public byte* @tags;
        public ushort* @contours;
        public int @flags;
    }
}