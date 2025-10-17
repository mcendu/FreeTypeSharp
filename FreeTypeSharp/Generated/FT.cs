namespace FreeTypeSharp
{
    using System.Runtime.InteropServices;
    using System;

    public unsafe static partial class FT
    {
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Init_FreeType(FT_LibraryRec_** alibrary);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Done_FreeType(FT_LibraryRec_* library);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_New_Face(FT_LibraryRec_* library, byte* filepathname, CLong face_index, FT_FaceRec_** aface);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_New_Memory_Face(FT_LibraryRec_* library, byte* file_base, CLong file_size, CLong face_index, FT_FaceRec_** aface);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Open_Face(FT_LibraryRec_* library, FT_Open_Args_* args, CLong face_index, FT_FaceRec_** aface);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Attach_File(FT_FaceRec_* face, byte* filepathname);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Attach_Stream(FT_FaceRec_* face, FT_Open_Args_* parameters);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Reference_Face(FT_FaceRec_* face);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Done_Face(FT_FaceRec_* face);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Select_Size(FT_FaceRec_* face, int strike_index);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Request_Size(FT_FaceRec_* face, FT_Size_RequestRec_* req);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Set_Char_Size(FT_FaceRec_* face, CLong char_width, CLong char_height, uint horz_resolution, uint vert_resolution);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Set_Pixel_Sizes(FT_FaceRec_* face, uint pixel_width, uint pixel_height);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Load_Glyph(FT_FaceRec_* face, uint glyph_index, FT_LOAD load_flags);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Load_Char(FT_FaceRec_* face, CULong char_code, FT_LOAD load_flags);
        [LibraryImport(LibName)]
        public static partial void FT_Set_Transform(FT_FaceRec_* face, FT_Matrix_* matrix, FT_Vector_* delta);
        [LibraryImport(LibName)]
        public static partial void FT_Get_Transform(FT_FaceRec_* face, FT_Matrix_* matrix, FT_Vector_* delta);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Render_Glyph(FT_GlyphSlotRec_* slot, FT_Render_Mode_ render_mode);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Get_Kerning(FT_FaceRec_* face, uint left_glyph, uint right_glyph, FT_Kerning_Mode_ kern_mode, FT_Vector_* akerning);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Get_Track_Kerning(FT_FaceRec_* face, CLong point_size, int degree, CLong* akerning);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Select_Charmap(FT_FaceRec_* face, FT_Encoding_ encoding);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Set_Charmap(FT_FaceRec_* face, FT_CharMapRec_* charmap);
        [LibraryImport(LibName)]
        public static partial int FT_Get_Charmap_Index(FT_CharMapRec_* charmap);
        [LibraryImport(LibName)]
        public static partial uint FT_Get_Char_Index(FT_FaceRec_* face, CULong charcode);
        [LibraryImport(LibName)]
        public static partial CULong FT_Get_First_Char(FT_FaceRec_* face, uint* agindex);
        [LibraryImport(LibName)]
        public static partial CULong FT_Get_Next_Char(FT_FaceRec_* face, CULong char_code, uint* agindex);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Face_Properties(FT_FaceRec_* face, uint num_properties, FT_Parameter_* properties);
        [LibraryImport(LibName)]
        public static partial uint FT_Get_Name_Index(FT_FaceRec_* face, byte* glyph_name);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Get_Glyph_Name(FT_FaceRec_* face, uint glyph_index, void* buffer, uint buffer_max);
        [LibraryImport(LibName)]
        public static partial byte* FT_Get_Postscript_Name(FT_FaceRec_* face);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Get_SubGlyph_Info(FT_GlyphSlotRec_* glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, int* p_arg2, FT_Matrix_* p_transform);
        [LibraryImport(LibName)]
        public static partial ushort FT_Get_FSType_Flags(FT_FaceRec_* face);
        [LibraryImport(LibName)]
        public static partial uint FT_Face_GetCharVariantIndex(FT_FaceRec_* face, CULong charcode, CULong variantSelector);
        [LibraryImport(LibName)]
        public static partial int FT_Face_GetCharVariantIsDefault(FT_FaceRec_* face, CULong charcode, CULong variantSelector);
        [LibraryImport(LibName)]
        public static partial uint* FT_Face_GetVariantSelectors(FT_FaceRec_* face);
        [LibraryImport(LibName)]
        public static partial uint* FT_Face_GetVariantsOfChar(FT_FaceRec_* face, CULong charcode);
        [LibraryImport(LibName)]
        public static partial uint* FT_Face_GetCharsOfVariant(FT_FaceRec_* face, CULong variantSelector);
        [LibraryImport(LibName)]
        public static partial CLong FT_MulDiv(CLong a, CLong b, CLong c);
        [LibraryImport(LibName)]
        public static partial CLong FT_MulFix(CLong a, CLong b);
        [LibraryImport(LibName)]
        public static partial CLong FT_DivFix(CLong a, CLong b);
        [LibraryImport(LibName)]
        public static partial CLong FT_RoundFix(CLong a);
        [LibraryImport(LibName)]
        public static partial CLong FT_CeilFix(CLong a);
        [LibraryImport(LibName)]
        public static partial CLong FT_FloorFix(CLong a);
        [LibraryImport(LibName)]
        public static partial void FT_Vector_Transform(FT_Vector_* vector, FT_Matrix_* matrix);
        [LibraryImport(LibName)]
        public static partial void FT_Library_Version(FT_LibraryRec_* library, int* amajor, int* aminor, int* apatch);
        [LibraryImport(LibName)]
        public static partial byte FT_Face_CheckTrueTypePatents(FT_FaceRec_* face);
        [LibraryImport(LibName)]
        public static partial byte FT_Face_SetUnpatentedHinting(FT_FaceRec_* face, byte value);
        [LibraryImport(LibName)]
        public static partial byte* FT_Error_String(FT_Error error_code);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_Decompose(FT_Outline_* outline, FT_Outline_Funcs_* func_interface, void* user);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_New(FT_LibraryRec_* library, uint numPoints, int numContours, FT_Outline_* anoutline);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_Done(FT_LibraryRec_* library, FT_Outline_* outline);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_Check(FT_Outline_* outline);
        [LibraryImport(LibName)]
        public static partial void FT_Outline_Get_CBox(FT_Outline_* outline, FT_BBox_* acbox);
        [LibraryImport(LibName)]
        public static partial void FT_Outline_Translate(FT_Outline_* outline, CLong xOffset, CLong yOffset);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_Copy(FT_Outline_* source, FT_Outline_* target);
        [LibraryImport(LibName)]
        public static partial void FT_Outline_Transform(FT_Outline_* outline, FT_Matrix_* matrix);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_Embolden(FT_Outline_* outline, CLong strength);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_EmboldenXY(FT_Outline_* outline, CLong xstrength, CLong ystrength);
        [LibraryImport(LibName)]
        public static partial void FT_Outline_Reverse(FT_Outline_* outline);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_Get_Bitmap(FT_LibraryRec_* library, FT_Outline_* outline, FT_Bitmap_* abitmap);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_Render(FT_LibraryRec_* library, FT_Outline_* outline, FT_Raster_Params_* @params);
        [LibraryImport(LibName)]
        public static partial FT_Orientation_ FT_Outline_Get_Orientation(FT_Outline_* outline);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_New_Size(FT_FaceRec_* face, FT_SizeRec_** size);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Done_Size(FT_SizeRec_* size);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Activate_Size(FT_SizeRec_* size);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Add_Module(FT_LibraryRec_* library, FT_Module_Class_* clazz);
        [LibraryImport(LibName)]
        public static partial FT_ModuleRec_* FT_Get_Module(FT_LibraryRec_* library, byte* module_name);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Remove_Module(FT_LibraryRec_* library, FT_ModuleRec_* module);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Property_Set(FT_LibraryRec_* library, byte* module_name, byte* property_name, void* value);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Property_Get(FT_LibraryRec_* library, byte* module_name, byte* property_name, void* value);
        [LibraryImport(LibName)]
        public static partial void FT_Set_Default_Properties(FT_LibraryRec_* library);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Reference_Library(FT_LibraryRec_* library);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_New_Library(FT_MemoryRec_* memory, FT_LibraryRec_** alibrary);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Done_Library(FT_LibraryRec_* library);
        [LibraryImport(LibName)]
        public static partial void FT_Set_Debug_Hook(FT_LibraryRec_* library, uint hook_index, void* debug_hook);
        [LibraryImport(LibName)]
        public static partial void FT_Add_Default_Modules(FT_LibraryRec_* library);
        [LibraryImport(LibName)]
        public static partial FT_TrueTypeEngineType_ FT_Get_TrueType_Engine_Type(FT_LibraryRec_* library);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_New_Glyph(FT_LibraryRec_* library, FT_Glyph_Format_ format, FT_GlyphRec_** aglyph);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Get_Glyph(FT_GlyphSlotRec_* slot, FT_GlyphRec_** aglyph);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Glyph_Copy(FT_GlyphRec_* source, FT_GlyphRec_** target);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Glyph_Transform(FT_GlyphRec_* glyph, FT_Matrix_* matrix, FT_Vector_* delta);
        [LibraryImport(LibName)]
        public static partial void FT_Glyph_Get_CBox(FT_GlyphRec_* glyph, uint bbox_mode, FT_BBox_* acbox);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Glyph_To_Bitmap(FT_GlyphRec_** the_glyph, FT_Render_Mode_ render_mode, FT_Vector_* origin, byte destroy);
        [LibraryImport(LibName)]
        public static partial void FT_Done_Glyph(FT_GlyphRec_* glyph);
        [LibraryImport(LibName)]
        public static partial void FT_Matrix_Multiply(FT_Matrix_* a, FT_Matrix_* b);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Matrix_Invert(FT_Matrix_* matrix);
        [LibraryImport(LibName)]
        public static partial FT_RendererRec_* FT_Get_Renderer(FT_LibraryRec_* library, FT_Glyph_Format_ format);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Set_Renderer(FT_LibraryRec_* library, FT_RendererRec_* renderer, uint num_params, FT_Parameter_* parameters);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Palette_Data_Get(FT_FaceRec_* face, FT_Palette_Data_* apalette);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Palette_Select(FT_FaceRec_* face, ushort palette_index, FT_Color_** apalette);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Palette_Set_Foreground_Color(FT_FaceRec_* face, FT_Color_ foreground_color);
        [LibraryImport(LibName)]
        public static partial byte FT_Get_Color_Glyph_Layer(FT_FaceRec_* face, uint base_glyph, uint* aglyph_index, uint* acolor_index, FT_LayerIterator_* iterator);
        [LibraryImport(LibName)]
        public static partial byte FT_Get_Color_Glyph_Paint(FT_FaceRec_* face, uint base_glyph, FT_Color_Root_Transform_ root_transform, FT_Opaque_Paint_* paint);
        [LibraryImport(LibName)]
        public static partial byte FT_Get_Color_Glyph_ClipBox(FT_FaceRec_* face, uint base_glyph, FT_ClipBox_* clip_box);
        [LibraryImport(LibName)]
        public static partial byte FT_Get_Paint_Layers(FT_FaceRec_* face, FT_LayerIterator_* iterator, FT_Opaque_Paint_* paint);
        [LibraryImport(LibName)]
        public static partial byte FT_Get_Colorline_Stops(FT_FaceRec_* face, FT_ColorStop_* color_stop, FT_ColorStopIterator_* iterator);
        [LibraryImport(LibName)]
        public static partial byte FT_Get_Paint(FT_FaceRec_* face, FT_Opaque_Paint_ opaque_paint, FT_COLR_Paint_* paint);
        [LibraryImport(LibName)]
        public static partial void FT_Bitmap_Init(FT_Bitmap_* abitmap);
        [LibraryImport(LibName)]
        public static partial void FT_Bitmap_New(FT_Bitmap_* abitmap);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Bitmap_Copy(FT_LibraryRec_* library, FT_Bitmap_* source, FT_Bitmap_* target);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Bitmap_Embolden(FT_LibraryRec_* library, FT_Bitmap_* bitmap, CLong xStrength, CLong yStrength);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Bitmap_Convert(FT_LibraryRec_* library, FT_Bitmap_* source, FT_Bitmap_* target, int alignment);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Bitmap_Blend(FT_LibraryRec_* library, FT_Bitmap_* source, FT_Vector_ source_offset, FT_Bitmap_* target, FT_Vector_* atarget_offset, FT_Color_ color);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_GlyphSlot_Own_Bitmap(FT_GlyphSlotRec_* slot);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Bitmap_Done(FT_LibraryRec_* library, FT_Bitmap_* bitmap);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Outline_Get_BBox(FT_Outline_* outline, FT_BBox_* abbox);
        [LibraryImport(LibName)]
        public static partial void FTC_Manager_Reset(FTC_ManagerRec_* manager);
        [LibraryImport(LibName)]
        public static partial void FTC_Manager_Done(FTC_ManagerRec_* manager);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_Manager_LookupFace(FTC_ManagerRec_* manager, void* face_id, FT_FaceRec_** aface);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_Manager_LookupSize(FTC_ManagerRec_* manager, FTC_ScalerRec_* scaler, FT_SizeRec_** asize);
        [LibraryImport(LibName)]
        public static partial void FTC_Node_Unref(FTC_NodeRec_* node, FTC_ManagerRec_* manager);
        [LibraryImport(LibName)]
        public static partial void FTC_Manager_RemoveFaceID(FTC_ManagerRec_* manager, void* face_id);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_CMapCache_New(FTC_ManagerRec_* manager, FTC_CMapCacheRec_** acache);
        [LibraryImport(LibName)]
        public static partial uint FTC_CMapCache_Lookup(FTC_CMapCacheRec_* cache, void* face_id, int cmap_index, uint char_code);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_ImageCache_New(FTC_ManagerRec_* manager, FTC_ImageCacheRec_** acache);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_ImageCache_Lookup(FTC_ImageCacheRec_* cache, FTC_ImageTypeRec_* type, uint gindex, FT_GlyphRec_** aglyph, FTC_NodeRec_** anode);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_ImageCache_LookupScaler(FTC_ImageCacheRec_* cache, FTC_ScalerRec_* scaler, FT_LOAD load_flags, uint gindex, FT_GlyphRec_** aglyph, FTC_NodeRec_** anode);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_SBitCache_New(FTC_ManagerRec_* manager, FTC_SBitCacheRec_** acache);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_SBitCache_Lookup(FTC_SBitCacheRec_* cache, FTC_ImageTypeRec_* type, uint gindex, FTC_SBitRec_** sbit, FTC_NodeRec_** anode);
        [LibraryImport(LibName)]
        public static partial FT_Error FTC_SBitCache_LookupScaler(FTC_SBitCacheRec_* cache, FTC_ScalerRec_* scaler, FT_LOAD load_flags, uint gindex, FTC_SBitRec_** sbit, FTC_NodeRec_** anode);
        [LibraryImport(LibName)]
        public static partial FT_StrokerBorder_ FT_Outline_GetInsideBorder(FT_Outline_* outline);
        [LibraryImport(LibName)]
        public static partial FT_StrokerBorder_ FT_Outline_GetOutsideBorder(FT_Outline_* outline);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_New(FT_LibraryRec_* library, FT_StrokerRec_** astroker);
        [LibraryImport(LibName)]
        public static partial void FT_Stroker_Set(FT_StrokerRec_* stroker, CLong radius, FT_Stroker_LineCap_ line_cap, FT_Stroker_LineJoin_ line_join, CLong miter_limit);
        [LibraryImport(LibName)]
        public static partial void FT_Stroker_Rewind(FT_StrokerRec_* stroker);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_ParseOutline(FT_StrokerRec_* stroker, FT_Outline_* outline, byte opened);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_BeginSubPath(FT_StrokerRec_* stroker, FT_Vector_* to, byte open);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_EndSubPath(FT_StrokerRec_* stroker);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_LineTo(FT_StrokerRec_* stroker, FT_Vector_* to);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_ConicTo(FT_StrokerRec_* stroker, FT_Vector_* control, FT_Vector_* to);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_CubicTo(FT_StrokerRec_* stroker, FT_Vector_* control1, FT_Vector_* control2, FT_Vector_* to);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_GetBorderCounts(FT_StrokerRec_* stroker, FT_StrokerBorder_ border, uint* anum_points, uint* anum_contours);
        [LibraryImport(LibName)]
        public static partial void FT_Stroker_ExportBorder(FT_StrokerRec_* stroker, FT_StrokerBorder_ border, FT_Outline_* outline);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Stroker_GetCounts(FT_StrokerRec_* stroker, uint* anum_points, uint* anum_contours);
        [LibraryImport(LibName)]
        public static partial void FT_Stroker_Export(FT_StrokerRec_* stroker, FT_Outline_* outline);
        [LibraryImport(LibName)]
        public static partial void FT_Stroker_Done(FT_StrokerRec_* stroker);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Glyph_Stroke(FT_GlyphRec_** pglyph, FT_StrokerRec_* stroker, byte destroy);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Glyph_StrokeBorder(FT_GlyphRec_** pglyph, FT_StrokerRec_* stroker, byte inside, byte destroy);
        [LibraryImport(LibName)]
        public static partial void FT_GlyphSlot_Embolden(FT_GlyphSlotRec_* slot);
        [LibraryImport(LibName)]
        public static partial void FT_GlyphSlot_AdjustWeight(FT_GlyphSlotRec_* slot, CLong xdelta, CLong ydelta);
        [LibraryImport(LibName)]
        public static partial void FT_GlyphSlot_Oblique(FT_GlyphSlotRec_* slot);
        [LibraryImport(LibName)]
        public static partial void FT_GlyphSlot_Slant(FT_GlyphSlotRec_* slot, CLong xslant, CLong yslant);
        [LibraryImport(LibName)]
        public static partial CLong FT_Sin(CLong angle);
        [LibraryImport(LibName)]
        public static partial CLong FT_Cos(CLong angle);
        [LibraryImport(LibName)]
        public static partial CLong FT_Tan(CLong angle);
        [LibraryImport(LibName)]
        public static partial CLong FT_Atan2(CLong x, CLong y);
        [LibraryImport(LibName)]
        public static partial CLong FT_Angle_Diff(CLong angle1, CLong angle2);
        [LibraryImport(LibName)]
        public static partial void FT_Vector_Unit(FT_Vector_* vec, CLong angle);
        [LibraryImport(LibName)]
        public static partial void FT_Vector_Rotate(FT_Vector_* vec, CLong angle);
        [LibraryImport(LibName)]
        public static partial CLong FT_Vector_Length(FT_Vector_* vec);
        [LibraryImport(LibName)]
        public static partial void FT_Vector_Polarize(FT_Vector_* vec, CLong* length, CLong* angle);
        [LibraryImport(LibName)]
        public static partial void FT_Vector_From_Polar(FT_Vector_* vec, CLong length, CLong angle);
        [LibraryImport(LibName)]
        public static partial int FT_Get_Gasp(FT_FaceRec_* face, uint ppem);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Get_Advance(FT_FaceRec_* face, uint gindex, FT_LOAD load_flags, CLong* padvance);
        [LibraryImport(LibName)]
        public static partial FT_Error FT_Get_Advances(FT_FaceRec_* face, uint start, uint count, FT_LOAD load_flags, CLong* padvances);
    }
}