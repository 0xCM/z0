//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct MemRefs
    {
        public static SegRef<T>[] many<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var dst = sys.alloc<SegRef<T>>(src.Length);
            many(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void many<T>(ReadOnlySpan<T> src, Span<SegRef<T>> dst)
            where T : struct
                => refs(src, dst);
    }
}