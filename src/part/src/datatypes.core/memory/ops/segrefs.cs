//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline), Op]
        public static SegRef<T>[] segrefs<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var dst = alloc<SegRef<T>>(src.Length);
            segrefs(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void segrefs<T>(ReadOnlySpan<T> src, Span<SegRef<T>> dst)
            where T : struct
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = segref(skip<T>(src,i), size<T>());
        }
    }
}