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

    public static class TernaryFunc
    {
        [MethodImpl(Inline)]
        public static Span<T3> apply<F,T0,T1,T2,T3>(F f, ReadOnlySpan<T0> A, ReadOnlySpan<T1> B, ReadOnlySpan<T2> C,  Span<T3> dst)
            where F : ITernaryFunc<T0,T1,T2,T3>
        {
            var count = dst.Length;
            ref readonly var a = ref head(A);
            ref readonly var b = ref head(B);
            ref readonly var c = ref head(C);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in a, i), skip(in b, i), skip(in c, i));
            return dst;
        }        
        
    }

}