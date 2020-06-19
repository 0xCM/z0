//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static MetadataRecords.LiteralField;
        
    using M = MetadataRecords;
    
    partial class MetadataFormat
    {       
        [Op]
        public static string format(in M.LiteralRecord src, char delimiter)
        {            
            var widths = FieldWidths(src.Kind);
            var count = FieldCount(src.Kind);
            var dst = alloc<string>(count);
            seek(dst, Sequence) = Render(src.Sequence, width(widths, Sequence));
            seek(dst, HeapSize) = RenderHex(src.HeapSize, width(widths, HeapSize));
            seek(dst, Length) = Render(src.Length, width(widths, Length));
            seek(dst, Offset) = RenderHex(src.Offset, width(widths, Offset));
            seek(dst, Value) = src.Value;
            return Delimit(dst, delimiter);
        }        
    }
}