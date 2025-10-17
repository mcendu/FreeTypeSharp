namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct FT_StreamDesc_
    {
        [FieldOffset(0)]
        public CLong value;
        [FieldOffset(0)]
        public void* pointer;
    }
}