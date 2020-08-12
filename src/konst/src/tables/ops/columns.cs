//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    partial struct Table 
    {
        public static ReadOnlySpan<TableColumn> columns<E>()
            where E : unmanaged, Enum
        {
            var fields = span(typeof(E).LiteralFields());
            var count = fields.Length;
            var dst = span<TableColumn>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                seek(dst,i) = new TableColumn((ushort)i, field.Name, (ushort)field.GetRawConstantValue());
            }
            return dst;
        }
    }
}