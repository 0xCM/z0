//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class UnaryFunc
    {
        [MethodImpl(Inline)]
        public static Span<T2> apply<F,T1,T2>(F f, ReadOnlySpan<T1> src, Span<T2> dst)
            where F : IUnaryFunc<T1,T2>
        {
            var count = dst.Length;
            ref readonly var input = ref head(src);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in input, i));
            return dst;
        }

    }

}