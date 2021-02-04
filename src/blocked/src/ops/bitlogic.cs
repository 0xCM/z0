//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Blocked
    {
        [MethodImpl(Inline), And, Closures(Closure)]
        public static ref readonly SpanBlock128<T> and<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.and<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), And, Closures(Closure)]
        public static ref readonly SpanBlock256<T> and<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.and<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Or, Closures(Closure)]
        public static ref readonly SpanBlock128<T> or<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.or<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Or, Closures(Closure)]
        public static ref readonly SpanBlock256<T> or<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.or<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static ref readonly SpanBlock128<T> xor<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.xor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static ref readonly SpanBlock256<T> xor<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.xor<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Xnor, Closures(Closure)]
        public static ref readonly SpanBlock128<T> xnor<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.xnor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Xnor, Closures(Closure)]
        public static ref readonly SpanBlock256<T> xnor<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.xnor<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> xornot<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.xornot<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> xornot<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.xornot<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static ref readonly SpanBlock128<T> impl<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.impl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static ref readonly SpanBlock256<T> impl<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.impl<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> nonimpl<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.nonimpl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> nonimpl<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.nonimpl<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> cimpl<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.cimpl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> cimpl<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.cimpl<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> cnonimpl<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.cnonimpl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> cnonimpl<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.cnonimpl<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static ref readonly SpanBlock128<T> nand<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.nand<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Nand, Closures(Closure)]
        public static ref readonly SpanBlock256<T> nand<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.nand<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static ref readonly SpanBlock128<T> nor<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.nor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Nor, Closures(Closure)]
        public static ref readonly SpanBlock256<T> nor<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.nor<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Not, Closures(Closure)]
        public static ref readonly SpanBlock128<T> not<T>(in SpanBlock128<T> a, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.not<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Not, Closures(Closure)]
        public static ref readonly SpanBlock256<T> not<T>(in SpanBlock256<T> a, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.not<T>(w256).Invoke(a, dst);

        [MethodImpl(Inline), Select, Closures(Closure)]
        public static ref readonly SpanBlock128<T> select<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> c, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref BSvc.select<T>(w128).Invoke(a, b, c, dst);

        [MethodImpl(Inline), Select, Closures(Closure)]
        public static ref readonly SpanBlock256<T> select<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> c, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.select<T>(w256).Invoke(a, b, c, dst);

        [MethodImpl(Inline)]
        static SpanBlock256<T> and<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, SpanBlock256<T> dst)
            where T : unmanaged
        {
            for(var i=0u; i<a.BlockCount; i++)
                gcpu.vstore(gvec.vand<T>(a.LoadVector(i), b.LoadVector(i)), ref dst.BlockRef(i));
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

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Block256<N,T> add<N,T>(ref Block256<N,T> x, in Block256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            add<T>(x,y,x);
            return ref x;
        }
    }
}