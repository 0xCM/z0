//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class RngX
    {
        /// <summary>
        /// Produces a generic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static RowVector<T> Vector<T>(this IPolyrand random, int len, Interval<T>? domain = null)
            where T : unmanaged
        {
            var dst = Z0.RowVector.alloc<T>(len);
            if(domain != null)
                random.Fill(domain.Value, len, ref dst[0]);
            else
                random.Fill(len, ref dst[0]);            
            return dst;
        }

        /// <summary>
        /// Produces a natural vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector<N,T> Vector<N,T>(this IPolyrand random, Interval<T> domain, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = Z0.RowVector.alloc<N,T>();
            random.Fill(domain, ref dst);
            return dst;
        }

        /// <summary>
        /// Produces a natural vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector<N,T> Vector<N,T>(this IPolyrand random, T min, T max,  N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = Z0.RowVector.alloc<N,T>();
            random.Fill(domain(min,max), ref dst);
            return dst;
        }

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector<N,T> Vector<N,T>(this IPolyrand random, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = Z0.RowVector.alloc<N,T>();
            random.Fill(ref dst);
            return dst;
        }

        /// <summary>
        /// Produces a natural vector over one domain and converts it to another
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="n">The natural vector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="S">The sample domain type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector<N,T> Vector<N,S,T>(this IPolyrand random, Interval<S> domain, N n = default)
            where T : unmanaged
            where S : unmanaged
            where N : unmanaged, ITypeNat
                => random.Vector<N,S>(domain).Convert<T>();

        /// <summary>
        /// Produces a natural vector over one domain and converts it to another
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The vector length</param>
        /// <param name="domain">The domain over which random selection will occur</param>
        /// <param name="rep">A target domain representative</param>
        /// <typeparam name="S">The source domain type</typeparam>
        /// <typeparam name="T">The target domain type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector<T> Vector<S,T>(this IPolyrand random, int len, Interval<S>? domain = null)        
            where S: unmanaged
            where T : unmanaged
                => random.Vector<S>(len,domain).Convert<T>();

        /// <summary>
        /// Populates a vector of natural length with random values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this IPolyrand random, Interval<T> domain, ref RowVector<N,T> vector, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => random.Fill<T>(domain, nati<N>(), ref vector.Data[0]);

        /// <summary>
        /// Populates a vector of natural length with random values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this IPolyrand random, ref RowVector<N,T> vector, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => random.Fill<T>(nati<N>(), ref vector.Data[0]);
    }
}