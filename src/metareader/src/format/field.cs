//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using static MetadataRecords;
    using static MetadataRecords.FieldRecordField;
    
    partial class MetadataFormat
    {       
        [Op]
        public static string format(in FieldRecord src, char delimiter)
        {            
            var widths = FieldWidths(src.Kind);
            var count = FieldCount(src.Kind);
            var dst = alloc<string>(count);
            seek(dst, Sequence) = Render(src.Sequence, width(widths, Sequence));
            seek(dst, Rva) = RenderHex(src.Rva, width(widths, Rva));
            seek(dst, Offset) = RenderHex(src.Offset, width(widths, Offset));
            seek(dst, Name) = Render(src.Name, width(widths, Name));
            seek(dst, Signature) = Render(src.Signature, width(widths, Signature));
            seek(dst, Attributes) = Render(src.Attributes, width(widths, Attributes));
            seek(dst, Marshalling) = Render(src.Marshalling, width(widths, Marshalling));
            return Delimit(dst,delimiter);
        }        
    }
}