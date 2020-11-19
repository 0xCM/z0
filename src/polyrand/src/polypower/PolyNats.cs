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
    using static TypeNats;

    partial class XTend
    {
        /// <summary>
        /// Allocates a span of natural dimensions and populates it with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The natural length of the produced span</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static NatSpan<N,T> NatSpan<N,T>(this IPolyrand random, Interval<T> domain, N n = default, Func<T,bool> filter = null)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => TypeNats.span(random.Span<T>((int)value(n), domain, filter), n);

        /// <summary>
        /// Allocates a table span of natural dimensions and populates the cells with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="rows">The row count</param>
        /// <param name="cols">The column count</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static TableSpan<M,N,T> TableSpan<M,N,T>(this IPolyrand random, M rows = default, N cols = default)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Z0.TableSpans.load<M,N,T>(random.Span<T>((int)NatCalc.mul(rows, cols)), rows, cols);

        /// <summary>
        /// Allocates a table span of natural dimensions and populates the cells with random values that
        /// are confined to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="rows">The row count</param>
        /// <param name="cols">The column count</param>
        /// <param name="cols">The interval domain to which values are confined</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static TableSpan<M,N,T> TableSpan<M,N,T>(this IPolyrand random, M rows, N cols, Interval<T> domain)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Z0.TableSpans.load<M,N,T>(random.Span<T>((int)NatCalc.mul(rows, cols), domain), rows, cols);
    }
}