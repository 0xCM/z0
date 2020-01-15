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

    public static class BinaryFunc
    {
        [MethodImpl(Inline)]
        public static Span<T2> apply<F,T0,T1,T2>(F f, ReadOnlySpan<T0> lhs, ReadOnlySpan<T1> rhs, Span<T2> dst)
            where F : IBinaryFunc<T0,T1,T2>
        {
            var count = dst.Length;
            ref readonly var lSrc = ref head(lhs);
            ref readonly var rSrc = ref head(rhs);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in lSrc, i), skip(in rSrc, i));
            return dst;
        }        

        [MethodImpl(Inline)]
        public static Span<T2> Apply<F,T0,T1,T2>(this F f, ReadOnlySpan<T0> lhs, ReadOnlySpan<T1> rhs, Span<T2> dst)
            where F : IBinaryFunc<T0,T1,T2>
                => apply(f,lhs,rhs,dst);        
    }

    public static class BinaryPred
    {
        [MethodImpl(Inline)]
        public static Span<bit> apply<F,T>(F f, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where F : IBinaryPred<T>
        {
            var count = dst.Length;
            ref readonly var lSrc = ref head(lhs);
            ref readonly var rSrc = ref head(rhs);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in lSrc, i), skip(in rSrc, i));
            return dst;
        }

    }

}