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

    partial class Blocked
    {
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

        [MethodImpl(Inline)]
        public static SpanBlock256<T> and<T>(in SpanBlock256<T> lhs, in SpanBlock256<T> rhs, SpanBlock256<T> dst)
            where T : unmanaged
        {
            for(var i=0u; i< lhs.BlockCount; i++)
                Vectors.vstore(gvec.vand<T>(lhs.LoadVector(i), rhs.LoadVector(i)), ref dst.BlockRef(i));
            return dst;
        }

        [MethodImpl(Inline), And, Closures(Integers)]
        public static ref readonly SpanBlock128<T> and<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.and<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), And, Closures(Integers)]
        public static ref readonly SpanBlock256<T> and<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.and<T>(w256).Invoke(a, b, dst);
    }
}