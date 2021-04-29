//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static memory;
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static And<T> and<T>()
            where T : unmanaged
                => default(And<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static And128<T> and<T>(W128 w)
            where T : unmanaged
                => default(And128<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static And256<T> and<T>(W256 w)
            where T : unmanaged
                => default(And256<T>);

        [MethodImpl(Inline), And, Closures(Integers)]
        public static Span<T> and<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(and<T>(), a,b,dst);

        [MethodImpl(Inline), And, Closures(Closure)]
        public static ref readonly SpanBlock128<T> and<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref and<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), And, Closures(Closure)]
        public static ref readonly SpanBlock256<T> and<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref and<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline)]
        static SpanBlock256<T> and<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, SpanBlock256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i<a.BlockCount; i++)
                gcpu.vstore(gcpu.vand<T>(a.LoadVector(i), b.LoadVector(i)), ref dst.BlockLead(i));
            return dst;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] & rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<N,T> and<N,T>(Block256<N,T> lhs, Block256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = RowVectors.blockalloc<N,T>();
            and<T>(lhs.Data, rhs.Data, dst);
            return dst;
        }
    }
}