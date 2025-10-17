namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_SfntName_
    {
        public ushort @platform_id;
        public ushort @encoding_id;
        public ushort @language_id;
        public ushort @name_id;
        public byte* @string;
        public uint @string_len;
    }
}