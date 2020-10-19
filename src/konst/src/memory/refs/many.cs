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

    partial struct MemRefs
    {
        [Op]
        public static Ref<T>[] many<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var dst = sys.alloc<Ref<T>>(src.Length);
            many(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void many<T>(ReadOnlySpan<T> src, Span<Ref<T>> dst)
            where T : struct
                => refs(src, dst);
    }
}