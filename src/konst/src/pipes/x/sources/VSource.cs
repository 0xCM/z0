//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Konst;
    using static z;

    public static class VSource
    {
        /// <summary>
        /// Produces a 128-bit cpu vector over random T-cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector128<T> CpuVector<T>(this ISource src, N128 w)
            where T : unmanaged
                => src.Blocks<T>(w).LoadVector();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector256<T> CpuVector<T>(this ISource src, N256 w)
            where T : unmanaged
                => src.Blocks<T>(w).LoadVector();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector512<T> CpuVector<T>(this ISource src, N512 w)
            where T : unmanaged
                => src.Blocks<T>(w).LoadVector();

        /// <summary>
        /// Produces a 128-bit cpu vector over random T-cells
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector128<T> CpuVector<T>(this ISource source, Vec128Kind<T> k, W128 w = default)
            where T : unmanaged
                => source.Blocks<T>(w).LoadVector();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector256<T> CpuVector<T>(this ISource src, Vec256Kind<T> k, W256 w = default)
            where T : unmanaged
                => src.Blocks<T>(w).LoadVector();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector512<T> CpuVector<T>(this ISource src, Vec512Kind<T> k)
            where T : unmanaged
                => src.Blocks<T>(w512).LoadVector();

        /// <summary>
        /// Produces a stream of 128-bit cpu vectors over random T-cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IEnumerable<Vector128<T>> CpuVectors<T>(this ISource src, N128 w)
            where T : unmanaged
        {
            while(true)
                yield return src.CpuVector<T>(w);
        }

        /// <summary>
        /// Produces a stream of 256-bit cpu vectors over random T-cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IEnumerable<Vector256<T>> CpuVectors<T>(this ISource src, N256 w)
            where T : unmanaged
        {
            while(true)
                yield return src.CpuVector<T>(w);
        }

        /// <summary>
        /// Produces a 128-bit cpu vector over random T-cells, each bound to a specified common domain
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IDomainSource src, N128 w, Interval<T> domain)
            where T : unmanaged
                => src.Blocks<T>(w,domain,1).LoadVector();

        /// <summary>
        /// Produces a stream of 128-bit cpu vectors over random T-cells, each bound to a specified common domain
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Vector128<T>> CpuVectors<T>(this IDomainSource src, N128 w, Interval<T> domain)
            where T : unmanaged
        {
            while(true)
                yield return src.CpuVector<T>(w, domain);
        }

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IDomainSource src, N128 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => src.Blocks<T>(w, domain, 1, filter).LoadVector();

        /// <summary>
        /// Produces a 256-bit cpu vector over random T-cells, each bound to a specified common domain
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IDomainSource src, N256 w, Interval<T> domain)
            where T : unmanaged
                => src.Blocks<T>(w, domain, 1).LoadVector();

        /// <summary>
        /// Produces a stream of 256-bit cpu vectors over random T-cells, each bound to a specified common domain
        /// </summary>
        /// <param name="source">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Vector256<T>> CpuVectors<T>(this IDomainSource source, N256 w, Interval<T> domain)
            where T : unmanaged
        {
            while(true)
                yield return source.CpuVector<T>(w, domain);
        }

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IDomainSource src, N256 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => src.Blocks<T>(w, domain, 1, filter).LoadVector();

        /// <summary>
        /// Produces a random 512-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> CpuVector<T>(this IDomainSource src, N512 w, Interval<T> domain, Func<T,bool> filter)
            where T : unmanaged
                => src.Blocks(w, domain, 1, filter).LoadVector();

        /// <summary>
        /// Produces a random 512-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which vector component values are constrained</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> CpuVector<T>(this IDomainSource src, N512 w, Interval<T> domain)
            where T : unmanaged
                => src.CpuVector(w,domain,null);

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector value</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this ISource src, N128 w, T t)
            where T : unmanaged
                => src.Blocks<T>(w,1).LoadVector();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector value</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this ISource src, N256 w, T t)
            where T : unmanaged
                => src.Blocks<T>(w,1).LoadVector();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The vector width selector value</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector512<T> CpuVector<T>(this ISource src, N512 w, T t)
            where T : unmanaged
                => src.Blocks<T>(w,1).LoadVector();
    }
}