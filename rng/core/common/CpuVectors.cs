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
        /// Produces a stream of 128-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IRandomStream<Vector128<T>> CpuVectors<T>(this IPolyrand random, N128 n, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
        {                
            IEnumerable<Vector128<T>> produce()
            {
                while(true)            
                    yield return random.CpuVector(n,domain,filter);
            }

            return stream(produce(), random.RngKind);
        }

        /// <summary>
        /// Produces a stream of 128-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain, if specified, from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IRandomStream<Vector128<T>> CpuVectors<T>(this IPolyrand random, N128 n,  Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.CpuVectors(n,Configure(domain),filter);

        /// <summary>
        /// Produces a stream of 128-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IRandomStream<Vector128<T>> CpuVectors<T>(this IPolyrand random, N128 n, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.CpuVectors(n,(min,max),filter);

        /// <summary>
        /// Produces a stream of 256-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IRandomStream<Vector256<T>> CpuVectors<T>(this IPolyrand random, N256 n, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
        {                
            IEnumerable<Vector256<T>> produce()
            {
                while(true)            
                    yield return random.CpuVector(n,domain,filter);
            }

            return stream(produce(), random.RngKind);
        }


        /// <summary>
        /// Produces a stream of 256-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain, if specified, from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IRandomStream<Vector256<T>> CpuVectors<T>(this IPolyrand random, N256 n, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.CpuVectors(n,Configure(domain),filter);

        /// <summary>
        /// Produces a stream of 256-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IRandomStream<Vector256<T>> CpuVectors<T>(this IPolyrand random, N256 n, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.CpuVectors(n,(min,max),filter);

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain, if specified, from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 n, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.BlockedSpan(n128,1, domain, filter));

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector<T>(this IPolyrand random, N128 n, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
                => CpuVecX.LoadVector(random.BlockedSpan(n, 1, domain, filter));

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
                => CpuVecX.LoadVector(random.BlockedSpan(n,1, (min, max), filter));

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
                => CpuVecX.LoadVector(random.BlockedSpan(n, 1, domain, filter));

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
                => CpuVecX.LoadVector(random.BlockedSpan(n,1, domain, filter));

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
                => CpuVecX.LoadVector(random.BlockedSpan(n,1, (min, max), filter));
    }
}