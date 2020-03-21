//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    /// <summary>
    /// Defines the signature of an operator that accepts a primal value and 
    /// partitions the value, or portion thereof, into segments of common length 
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span of sufficent length to receive the partition segments</param>
    /// <typeparam name="S">The primal source type</typeparam>
    /// <typeparam name="T">The primal target type</typeparam>
    public delegate void Partitioner<S,T>(S src, Span<T> dst)
        where T : unmanaged;

    public static class SpanOps
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
        public static Span<bit> apply<F,T>(F f, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where F : IBinaryPredicate<T>
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

        [MethodImpl(Inline)]
        public static Span<bit> apply<F,T>(F f, ReadOnlySpan<T> src, Span<bit> dst)
            where F : IUnaryPredicate<T>
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