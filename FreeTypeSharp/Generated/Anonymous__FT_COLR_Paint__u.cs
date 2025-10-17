namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct Anonymous__FT_COLR_Paint__u
    {
        [FieldOffset(0)]
        public FT_PaintColrLayers_ colr_layers;
        [FieldOffset(0)]
        public FT_PaintGlyph_ glyph;
        [FieldOffset(0)]
        public FT_PaintSolid_ solid;
        [FieldOffset(0)]
        public FT_PaintLinearGradient_ linear_gradient;
        [FieldOffset(0)]
        public FT_PaintRadialGradient_ radial_gradient;
        [FieldOffset(0)]
        public FT_PaintSweepGradient_ sweep_gradient;
        [FieldOffset(0)]
        public FT_PaintTransform_ transform;
        [FieldOffset(0)]
        public FT_PaintTranslate_ translate;
        [FieldOffset(0)]
        public FT_PaintScale_ scale;
        [FieldOffset(0)]
        public FT_PaintRotate_ rotate;
        [FieldOffset(0)]
        public FT_PaintSkew_ skew;
        [FieldOffset(0)]
        public FT_PaintComposite_ composite;
        [FieldOffset(0)]
        public FT_PaintColrGlyph_ colr_glyph;
    }
}