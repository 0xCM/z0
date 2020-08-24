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

    partial class memory
    {
        [MethodImpl(Inline), Op]
        public static QuadRef<T> refs<T>(in T r0, in T r1, in T r2, in T r3)
            where T : struct
            => new QuadRef<T>(r0,r1,r2,r3);

        [MethodImpl(Inline), Op]
        public static void refs<T>(ReadOnlySpan<T> src, Span<Ref<T>> dst)
            where T : struct
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = @ref(skip(src,i), size<T>());
        }

        [MethodImpl(Inline), Op]
        public static Ref<T>[] refs<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var dst = sys.alloc<Ref<T>>(src.Length);
            refs(src,dst);
            return dst;
        }
    }
}