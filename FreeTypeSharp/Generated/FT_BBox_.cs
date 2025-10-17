namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_BBox_
    {
        public CLong xMin;
        public CLong yMin;
        public CLong xMax;
        public CLong yMax;
    }
}