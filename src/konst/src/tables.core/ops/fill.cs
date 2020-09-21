//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static void fill<T>(in TableFields fields, ReadOnlySpan<T> src, TableRows<T> dst)
            where T : struct
        {
            var count = dst.Length;
            for(var i=0u; i<count; i++)
                fill(fields, i, skip(src,i), ref dst[i]);
        }

        [MethodImpl(Inline)]
        public static void fill<T>(in TableFields fields, uint index, in T src, ref TableRow<T> dst)
            where T : struct
        {
            var tr = __makeref(edit(src));
            var count = fields.Length;
            dst.Source = src;
            dst.RowIndex = index;
            for(var i=0u; i<count; i++)
            {
                ref readonly var field = ref fields[i].Definition;
                dst[i] = field.GetValueDirect(tr);
            }
        }
    }
}