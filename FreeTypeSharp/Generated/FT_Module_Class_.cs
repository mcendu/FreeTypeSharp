namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_Module_Class_
    {
        public CULong @module_flags;
        public CLong @module_size;
        public byte* @module_name;
        public CLong @module_version;
        public CLong @module_requires;
        public void* @module_interface;
        public void* @module_init;
        public void* @module_done;
        public void* @get_interface;
    }
}