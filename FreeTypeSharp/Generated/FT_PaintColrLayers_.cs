namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FT_PaintColrLayers_
    {
        public FT_LayerIterator_ layer_iterator;
    }
}