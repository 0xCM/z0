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
    using static MetadataRecords.ConstantField;
    
    partial class MetadataFormat
    {       
        [Op]
        public static string format(in ConstantRecord src, char delimiter)
        {            
            var widths = FieldWidths(src.Kind);
            var count = FieldCount(src.Kind);
            var dst = alloc<string>(count);
            seek(dst, Sequence) = Render(src.Sequence, width(widths, Sequence));
            seek(dst, Parent) = Render(src.Parent, width(widths, Parent));
            seek(dst, DataType) = Render(src.DataType, width(widths, DataType));
            seek(dst, Value) = Render(src.Value, width(widths, Value));
            return Delimit(dst, delimiter);
        }        
    }
}