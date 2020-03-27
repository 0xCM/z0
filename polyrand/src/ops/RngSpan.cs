//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Polyfun;
    using static refs;

    public static class RngSpan
    {
        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void SpanFill<T>(this IPolyrand random, Span<T> dst)
            where T : unmanaged
                => random.Fill(random.Domain<T>(), dst.Length, ref head(dst));

        /// <summary>
        /// Produces a span of random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
        {
            Span<T> dst = new T[length];
            random.Fill(domain.ValueOrElse(() => random.Domain<T>()), length,ref head(dst), filter);
            return dst;
        }

        /// <summary>
        /// Produces a span of random values constraint to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The interval domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : unmanaged
                => random.Span<T>(length,domain,null);

        /// <summary>
        /// Produces a span of random values constraint to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The interval domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, T min, T max, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Span<T>(length,(min,max),filter);

        /// <summary>
        /// Produces a span of random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The span length</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, T t)
            where T : unmanaged
                => random.Span<T>(length);

        /// <summary>
        /// Fills a caller-allocated span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="dst">The target span</param>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void SpanFill<T>(this IPolyrand random, T min, T max, Span<T> dst)
            where T : unmanaged
                => random.Fill((min,max), dst.Length, ref head(dst));

        /// <summary>
        /// Fills a caller-supplied target with random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static void SpanFill(this IPolyrand random, Span<bit> dst)
        {
            const int w = 64;
            var pos = -1;
            var last = dst.Length - 1;

            while(pos <= last)
            {
                var data = random.Next<ulong>();
                
                var i = -1;
                while(++pos <= last && ++i < w)
                    dst[pos] = bit.test(data,i);
            }
        }

        /// <summary>
        /// Allocates and produces a readonly span populated with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadOnlySpan<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : unmanaged
                => random.Span<T>(length, domain, filter);

        /// <summary>
        /// Allocates and produces a punctured span populated with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> NonZeroSpan<T>(this IPolyrand random, int samples, Interval<T> domain)
            where T : unmanaged
                => random.Span<T>(samples, domain, x => Numeric.nonz(x));

        /// <summary>
        /// Allocates and produces a punctured span populated with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> NonZeroSpan<T>(this IPolyrand random, int samples)
            where T : unmanaged
                => random.Span<T>(samples, random.Domain<T>(), x => Numeric.nonz(x));
    }
}