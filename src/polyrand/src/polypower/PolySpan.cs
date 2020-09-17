//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    public static partial class PolySpan
    {
        public static Span<T> create<T>(IPolyrand random, int length, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
        {
            var dst = span<T>(length);
            random.Fill(domain, length, ref first(dst), filter);
            return dst;
        }

        /// <summary>
        /// Produces a span of random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : unmanaged
                => create<T>(random, length, domain);

        /// <summary>
        /// Produces a span of random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The span length</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Span<T>(this IPolyrand random, int length)
            where T : unmanaged
                => create<T>(random, length, Interval<T>.Full);

        /// <summary>
        /// Produces a span of random values constraint to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The interval domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => create<T>(random, length, domain, filter);

        /// <summary>
        /// Produces a span of random values constraint to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The interval domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Span<T> Span<T>(this IPolyrand random, int length, T min, T max, Func<T,bool> filter = null)
            where T : unmanaged
                => create<T>(random, length, (min, max), filter);

        /// <summary>
        /// Allocates a span of specified natural length and populates it with random T-values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Span<N,T>(this IPolyrand src, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => create<T>(src, (int)nat64u(n), Interval<T>.Full);

        /// <summary>
        /// Allocates a span of specified natural length and populates it with random T-values over a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Span<N,T>(this IPolyrand src, T min, T max, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => create<T>(src, (int)nat64u(n), (min, max));

        /// <summary>
        /// Allocates a span of specified natural length and populates it with random T-values over a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Span<N,T>(this IPolyrand src, Interval<T> domain, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => create<T>(src, (int)nat64u(n), domain);

        /// <summary>
        /// Allocates and produces a punctured span populated with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Span<T> NonZeroSpan<T>(this IPolyrand random, int samples, Interval<T> domain)
            where T : unmanaged
                => random.Span<T>(samples, domain, x => gmath.nonz(x));

        /// <summary>
        /// Allocates and produces a punctured span populated with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Span<T> NonZeroSpan<T>(this IPolyrand random, int samples)
            where T : unmanaged
                => random.Span<T>(samples, random.Domain<T>(), x => gmath.nonz(x));
    }
}