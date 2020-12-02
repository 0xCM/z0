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

    partial class gbits
    {
        [MethodImpl(Inline), Unpack, Closures(Closure)]
        public static Span<bit> unpack<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
        {
            var srcsize = bitsize<T>();
            var bitcount = bitsize<T>()*src.Length;
            ref var target = ref first(dst);
            var k = 0;
            for(var i=0; i <src.Length; i++)
            for(byte j=0; j <srcsize; j++, k++)
                seek(target, k) = testbit(skip(src,i), j);
            return dst;
        }

        public static Span<bit> unpack<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => unpack(src, alloc<bit>(bitsize<T>()*src.Length));
    }
}