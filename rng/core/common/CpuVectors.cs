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

    using static zfunc;

    partial class RngX
    {        
        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain, if specified, from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 w)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 w)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w));

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 w, Interval<T> domain, Func<T,bool> filter)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w, 1, domain, filter));

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 w, Interval<T> domain)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w, 1, domain));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 w, Interval<T> domain, Func<T,bool> filter)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w,1, domain, filter));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 w, Interval<T> domain)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w,1, domain));

        /// <summary>
        /// Produces a random 512-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which component values are constrained</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> CpuVector<T>(this IPolyrand random, N512 w, Interval<T> domain, Func<T,bool> filter)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(w,1, domain, filter));

        /// <summary>
        /// Produces a random 512-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector</param>
        /// <param name="domain">An interval to which vector component values are constrained</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> CpuVector<T>(this IPolyrand random, N512 w, Interval<T> domain)        
            where T : unmanaged
                => random.CpuVector(w,domain,null);

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 w, T min, T max, Func<T,bool> filter)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(w,1, (min, max), filter));

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 w, T min, T max)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(w,1, (min, max), (Func<T,bool>)null));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 n, T min, T max, Func<T,bool> filter)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(n,1, (min, max), filter));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">A domain refinement filter</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 n, T min, T max)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(n,1, (min, max), (Func<T,bool>)null));

        /// <summary>
        /// Produces a random 512-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> CpuVector<T>(this IPolyrand random, N512 n, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(n,1, (min, max), filter));

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector value</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 w, T t)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w,1));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector value</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 w, T t)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w,1));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector value</param>
        /// <param name="t">The component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> CpuVector<T>(this IPolyrand random, N512 w, T t)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks<T>(w,1));
    }
}