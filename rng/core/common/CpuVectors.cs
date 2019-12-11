//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 w, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(n128,1, domain, filter));

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 w, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(w, 1, domain, filter));

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 n, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(n,1, (min, max), filter));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain, if specified, from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 n, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(n, 1, domain, filter));

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 n, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(n,1, domain, filter));
                
        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 n, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.Blocks(n,1, (min, max), filter));
    }
}