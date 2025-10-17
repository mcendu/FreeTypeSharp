namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Var_Axis_
    {
        public byte* @name;
        public CLong @minimum;
        public CLong @def;
        public CLong @maximum;
        public CULong @tag;
        public uint @strid;
    }
}