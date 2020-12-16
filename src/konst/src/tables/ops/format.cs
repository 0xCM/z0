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
        [Op, Closures(AllNumeric)]
        public static ReadOnlySpan<string> format<T>(in CellFormatter<T,string> formatter, ReadOnlySpan<T> src)
        {
            var dst = span<string>(src.Length);
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = formatter.Format(skip(src,i));
            return dst;
        }

        public static void format<F,T>(in TableFields<F> fields, in T src, StringBuilder dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            var count = fields.Count;
            var view = fields.View;
            var tt = typeof(T);
            var tr = __makeref(edit(src));
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref skip(view,i);
                var width = field.Width;
                var type = field.DataType;
                var def = field.Definition;
                var val = ClrQuery.value(def,tr);
                var fmt = text.format(val, type, FieldDelimiter, width);
                dst.Append(fmt);
            }
        }

        public static void format<F,T>(in T src, StringBuilder dst)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            format(index<F,T>(), src, dst);
        }

        public static string format<F,T>(in T src)
            where T : struct, ITable<F,T>
            where F : unmanaged, Enum
        {
            var dst = text.build();
            format(index<F,T>(), src, dst);
            return dst.ToString();
        }
    }
}