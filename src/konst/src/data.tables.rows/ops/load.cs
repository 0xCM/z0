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

    partial struct TableRows
    {
        [MethodImpl(Inline)]
        public static TableRow<T> load<T>(uint index, in T src)
            where T : struct
                => load(TableFields.index<T>(), index, src);

        [MethodImpl(Inline)]
        public static TableRow<T> load<T>(in TableFieldIndex fields, uint index, in T src)
            where T : struct
        {
            var dst = alloc<T>(fields.Count);
            load(fields, index, src, ref dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static TableRows<T> load<T>(ReadOnlySpan<T> src)
            where T : struct
                => load(TableFields.index<T>(), src);

        [MethodImpl(Inline)]
        public static TableRows<T> load<T>(in TableFieldIndex fields, ReadOnlySpan<T> src)
            where T : struct
        {
            var count = (uint)src.Length;
            var buffer = alloc<T>(fields, count);
            load(fields,src,buffer);
            return buffer;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void load<T>(in TableFieldIndex fields, ReadOnlySpan<T> src, in TableRows<T> dst)
            where T : struct
        {
            var count = (uint)src.Length;
            var target = dst.Edit;
            for(var i=0u; i<count; i++)
                load(fields, i, skip(src, i), ref seek(target,i));
        }

        [MethodImpl(Inline)]
        public static void load<T>(in TableFieldIndex fields, uint index, in T src, ref TableRow<T> dst)
            where T : struct
        {
            var tr = __makeref(edit(src));
            var count = fields.Length;
            dst.Source = src;
            dst.RowIndex = index;
            var fv = fields.View;
            var target = span(dst.Cells);
            for(var i=0u; i<count; i++)
                seek(target,i) = skip(fv, i).Definition.GetValueDirect(tr);
        }
    }
}