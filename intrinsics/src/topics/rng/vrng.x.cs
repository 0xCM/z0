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

    using static zfunc;

    public static class VRngX
    {
        /// <summary>
        /// Creates a 128-bit vectorized emitter predicated a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector bit width</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static VRandom128<T> VectorEmitter<T>(this IPolyrand random, N128 w, T t = default)
            where T : unmanaged
                => vrng.emitter(w,random,t);

        /// <summary>
        /// Creates a 256-bit vectorized emitter predicated a random source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector bit width</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static VRandom256<T> VectorEmitter<T>(this IPolyrand random, N256 w, T t = default)
            where T : unmanaged
                => vrng.emitter(w,random,t);

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
                => random.Blocks<T>(w).LoadVector();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="w">The vector width selector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> CpuVector<T>(this IPolyrand random, N256 w)        
            where T : unmanaged
                => random.Blocks<T>(w).LoadVector();

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
                => random.Blocks<T>(w, domain, 1, filter).LoadVector();

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
                => random.Blocks<T>(w,domain,1).LoadVector();

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
                => random.Blocks<T>(w, domain, 1, filter).LoadVector();

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
                => random.Blocks<T>(w,domain,1).LoadVector();

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
                => random.Blocks(w, domain, 1, filter).LoadVector();

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
                => random.Blocks(w, (min, max), 1, filter).LoadVector();

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
                => random.Blocks(w,(min, max), 1,(Func<T,bool>)null).LoadVector();

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
                => random.Blocks(n, (min, max), 1, filter).LoadVector();

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
                => random.Blocks(n, (min, max), 1, (Func<T,bool>)null).LoadVector();

        /// <summary>
        /// Produces a random 512-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> CpuVector<T>(this IPolyrand random, N512 n, T min, T max, Func<T,bool> filter)        
            where T : unmanaged
                => random.Blocks(n, (min, max),1, filter).LoadVector();

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
                => random.Blocks<T>(w,1).LoadVector();

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
                => random.Blocks<T>(w,1).LoadVector();

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
                => random.Blocks<T>(w,1).LoadVector();

        /// <summary>
        /// Produces a random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static Perm Perm(this IPolyrand random, int n)
            => permute.identity(n).Shuffle(random);

        /// <summary>
        /// Produces a random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static Perm Perm(this IPolyrand random, uint n)
            => random.Perm((int)n);

        /// <summary>
        /// Produces a stream of random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The length representative</param>
        /// <param name="rep">A primal type representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal symbol type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Perm> Perms(this IPolyrand random, int len)
        {
            while(true)
                yield return random.Perm(len);
        }

        /// <summary>
        /// Produces a random permutation of natural length N
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The length representative</param>
        /// <param name="rep">A primal type representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal symbol type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> Perm<N>(this IPolyrand random, N n = default)
            where N : unmanaged, ITypeNat
                => Z0.permute.natural(n).Shuffle(random);
                
        /// <summary>
        /// Produces a stream of random permutation of natural length N
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The length representative</param>
        /// <param name="rep">A primal type representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal symbol type</typeparam>
        public static IEnumerable<NatPerm<N>> Perms<N>(this IPolyrand random, N n = default)
            where N : unmanaged, ITypeNat
        {
            while(true)
                yield return random.Perm(n);
        }                        
    }
}