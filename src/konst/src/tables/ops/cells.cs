//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    partial struct Table
    {
        public static ReadOnlySpan<TableColumn> columns(Type table)
        {
            var fields = span(table.DeclaredFields());
            var count = fields.Length;
            var dst = span<TableColumn>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                seek(dst,i) = new TableColumn((ushort)i, field.Name, 0);
            }
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string cell<T>(in CellFormatter<T,string> formatter, in T src)            
            => formatter.Format(src);

        [Op, Closures(AllNumeric)]
        public static ReadOnlySpan<string> cells<T>(in CellFormatter<T,string> formatter, ReadOnlySpan<T> src)
        {
            var dst = span<string>(src.Length);
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = cell(formatter, skip(src,i));            
            return dst;
        }
    }
}