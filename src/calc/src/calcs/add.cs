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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Add<T> add<T>()
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Add, Closures(Integers)]
        public static Span<T> add<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(Calcs.add<T>(), l, r, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> add<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref BSvc.add<T>(w256).Invoke(a, b, dst);


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
            Calcs.add<T>(x,y,x);
            return ref x;
        }
    }
}