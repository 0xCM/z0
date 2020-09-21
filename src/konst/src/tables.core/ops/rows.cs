//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableRows<T> rows<T>(ReadOnlySpan<T> src)
            where T : struct
                => rows(fields<T>(), src);

        [MethodImpl(Inline)]
        public static TableRows<T> rows<T>(in TableFields fields, ReadOnlySpan<T> src)
            where T : struct
        {
            var kRows = (uint)src.Length;
            var dst = rowalloc<T>(fields, kRows);
            for(var i=0u; i<kRows; i++)
                fill(fields, i, skip(src,i), ref dst[i]);
            return dst;
        }
    }
}