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
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> CpuVec128<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVec128();

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> CpuVec128<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVec128();

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> CpuVec128<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, closed(min,max), filter).LoadVec128();
                
        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IPolyrand random, Interval<T> domain)        
            where T : unmanaged
                => random.Span256<T>(1, domain).LoadVec256();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IPolyrand random)        
            where T : unmanaged
                => random.Span256<T>(1).LoadVec256();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span256<T>(1, domain, filter).LoadVec256();


        /// <summary>
        /// Produces a stream of random 256-bit cpu vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IRandomStream<Vec256<T>> CpuVec256Stream<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
        {
            IEnumerable<Vec256<T>> produce()
            {
                while(true)            
                    yield return random.CpuVec256(domain,filter);
            }

            return stream(produce(), random.RngKind);
        }


        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector128<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVector128();


        /// <summary>
        /// Produces a stream of 128-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IRandomStream<Vector128<T>> CpuVectors128<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
        {
                
            IEnumerable<Vector128<T>> produce()
            {
                while(true)            
                    yield return random.CpuVector128(domain,filter);
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
        public static IRandomStream<Vector128<T>> CpuVectors128<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.CpuVectors128(Configure(domain),filter);

        /// <summary>
        /// Produces a stream of 128-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IRandomStream<Vector128<T>> CpuVectors128<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.CpuVectors128((min,max),filter);

        /// <summary>
        /// Produces a stream of 256-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IRandomStream<Vector256<T>> CpuVectors256<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
        {
                
            IEnumerable<Vector256<T>> produce()
            {
                while(true)            
                    yield return random.CpuVector256(domain,filter);
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
        public static IRandomStream<Vector256<T>> CpuVectors256<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.CpuVectors256(Configure(domain),filter);

        /// <summary>
        /// Produces a stream of 256-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IRandomStream<Vector256<T>> CpuVectors256<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.CpuVectors256((min,max),filter);

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector128<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVector128();

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector128<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, (min,max), filter).LoadVector128();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector256<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span256<T>(1, domain, filter).LoadVector256();
 
        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector256<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span256<T>(1, domain, filter).LoadVector256();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector256<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span256<T>(1, (min,max), filter).LoadVector256();

    }
}