//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    public static class PolySpan
    {
        /// <summary>
        /// Produces a span of random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="length">The span length</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static Span<T> Span<T>(this ISource src, int length)
            where T : unmanaged
        {
            var dst = span<T>(length);
            src.Fill(length, ref first(dst));
            return dst;
        }

        static Span<T> create<T>(IDomainSource src, int length, Interval<T> domain, Func<T,bool> filter = null)
            where T : unmanaged
        {
            var dst = span<T>(length);
            src.Fill(domain, length, ref first(dst), filter);
            return dst;
        }

        /// <summary>
        /// Produces a span of random values constraint to a specified domain
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The interval domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Span<T> Span<T>(this IDomainSource src, int length, T min, T max, Func<T,bool> filter = null)
            where T : unmanaged
                => create<T>(src, length, (min, max), filter);

        /// <summary>
        /// Produces a span of random values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Span<T> Span<T>(this IDomainSource src, int length, Interval<T> domain)
            where T : unmanaged
        {
            var dst = span<T>(length);
            src.Fill(domain, length, ref first(dst));
            return dst;
        }


        /// <summary>
        /// Produces a span of random values constraint to a specified domain
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The interval domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        public static Span<T> Span<T>(this IDomainSource src, int length, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
        {
            var dst = span<T>(length);
            src.Fill(domain, length, ref first(dst), filter);
            return dst;
        }
    }
}