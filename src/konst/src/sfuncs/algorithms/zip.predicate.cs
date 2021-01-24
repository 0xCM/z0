//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct SFx
    {
        [MethodImpl(Inline)]
        public static Span<bit> zip<F,T>(in SpanBlock128<T> a, SpanBlock128<T> b, Span<bit> dst, F f)
            where T : unmanaged
            where F : IBinaryPred128<T>
        {
            var blocks = a.BlockCount;
            ref var result = ref first(dst);
            for(var block = 0; block<blocks; block++)
                seek(result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bit> zip<F,T>(in SpanBlock256<T> a, in SpanBlock256<T> b, Span<bit> dst, F f)
            where T : unmanaged
            where F : IBinaryPred256<T>
        {
            var blocks = a.BlockCount;
            ref var result = ref first(dst);
            for(var block = 0; block<blocks; block++)
                seek(result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }
    }
}