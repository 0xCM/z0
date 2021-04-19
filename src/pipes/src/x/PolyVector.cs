//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines the matrix api surface
    /// </summary>
    public static class PolyVector
    {
        /// <summary>
        /// Produces a blocked vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static RowVector256<T> VectorBlock<T>(this IPolyrand random, int len, Interval<T>? domain = null)
            where T : unmanaged
        {
            var dst = Z0.RowVectors.blockalloc<T>(len);
            if(domain != null)
                random.Fill(domain.Value, len, ref dst[0]);
            else
                random.Fill(len, ref dst[0]);
            return dst;
        }

        /// <summary>
        /// Produces a generic random vector over one domain and converts it to a vector over another
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The vector length</param>
        /// <param name="domain">The domain over which random selection will occur</param>
        /// <param name="t">A target domain representative</param>
        /// <typeparam name="S">The source domain type</typeparam>
        /// <typeparam name="T">The target domain type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector256<T> VectorBlock<S,T>(this IPolyrand random, int len, Interval<S>? domain = null)
            where S: unmanaged
            where T : unmanaged
                => random.VectorBlock<S>(len,domain).Convert<T>();

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<N,T> VectorBlock<N,T>(this IPolyrand random, Interval<T> domain, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = Z0.RowVectors.blockalloc<N, T>();
            random.Fill(domain, ref dst);
            return dst;
        }

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="n">The natural vector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="S">The sample domain type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<N,T> VectorBlock<N,S,T>(this IPolyrand random, Interval<S> domain, N n = default)
            where T : unmanaged
            where S: unmanaged
            where N : unmanaged, ITypeNat
                => random.VectorBlock<N,S>(domain).Convert<T>();

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<N,T> VectorBlock<N,T>(this IPolyrand random,  N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = Z0.RowVectors.blockalloc<N, T>();
            random.Fill(ref dst);
            return dst;
        }

        /// <summary>
        /// Populates a vector of natural length with random values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this IPolySource random, Interval<T> domain, ref Block256<N,T> vector, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => random.Fill<T>(domain, nat32i<N>(), ref vector.Unsized[0]);

        /// <summary>
        /// Populates a vector of natural length with random values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this IPolySource random, ref Block256<N,T> vector, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => random.Fill<T>(nat32i<N>(), ref vector.Unsized[0]);

        /// <summary>
        /// Produces a generic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static RowVector<T> Vector<T>(this IPolySource random, int len, Interval<T>? domain = null)
            where T : unmanaged
        {
            var dst = Z0.RowVectors.alloc<T>(len);
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
        public static RowVector<N,T> Vector<N,T>(this IPolySource random, Interval<T> domain, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = Z0.RowVectors.alloc<N,T>();
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
        public static RowVector<N,T> Vector<N,T>(this IPolySource random, T min, T max,  N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = Z0.RowVectors.alloc<N,T>();
            random.Fill(Interval.closed(min,max), ref dst);
            return dst;
        }

        /// <summary>
        /// Allocates and populates a vector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector<N,T> Vector<N,T>(this IPolySource random, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var dst = Z0.RowVectors.alloc<N,T>();
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
        public static RowVector<N,T> Vector<N,S,T>(this IPolySource random, Interval<S> domain, N n = default)
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
        public static RowVector<T> Vector<S,T>(this IPolySource random, int len, Interval<S>? domain = null)
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
        public static void Fill<N,T>(this IPolySource random, Interval<T> domain, ref RowVector<N,T> vector, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => random.Fill<T>(domain, nat32i<N>(), ref vector.Data[0]);

        /// <summary>
        /// Populates a vector of natural length with random values from the source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <param name="vector">The vector to populate</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this IPolySource random, ref RowVector<N,T> vector, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => random.Fill<T>(memory.nat32i<N>(), ref vector.Data[0]);

        /// <summary>
        /// Effects a component-wise contraction on the source vector on a source vector of unsigned primal type,
        /// dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The unsigned primal type</typeparam>
         public static Block256<N,T> Contract<N,T>(this Block256<N,T> src, Block256<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = NatSpans.alloc<N,T>();
            for(var i=0; i<dst.Count; i++)
                dst[i] = gAlg.squeeze(src[i],max[i]);
            return dst;
        }

        /// <summary>
        /// Effects a component-wise contraction on the source vector on a source vector of unsigned primal type,
        /// dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The unsigned primal type</typeparam>
         public static RowVector256<T> Contract<T>(this RowVector256<T> src, RowVector256<T> max)
            where T : unmanaged
        {
            var len = src.Length;
            var dst = Z0.RowVectors.blockalloc<T>(len);
            for(var i=0; i<dst.Length; i++)
                dst[i] = gAlg.squeeze(src[i],max[i]);
            return dst;
        }
    }
}