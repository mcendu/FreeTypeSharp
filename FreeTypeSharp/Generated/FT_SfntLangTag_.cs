namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_SfntLangTag_
    {
        public byte* @string;
        public uint @string_len;
    }
}