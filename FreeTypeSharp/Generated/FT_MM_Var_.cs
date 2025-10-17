namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_MM_Var_
    {
        public uint num_axis;
        public uint num_designs;
        public uint num_namedstyles;
        public FT_Var_Axis_* axis;
        public FT_Var_Named_Style_* namedstyle;
    }
}