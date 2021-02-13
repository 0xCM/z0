//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    public static class PRngX
    {
        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static ref readonly Perm<T> Shuffle<T>(this IDomainSource random, in Perm<T> src)
            where T : unmanaged
        {
            random.Shuffle(src.Terms);
            return ref src;
        }

        /// <summary>
        /// Produces a random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static Perm Perm(this IDomainSource random, int n)
            => shuffle(Z0.Perm.Identity(n), random);

        /// <summary>
        /// Produces a random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static Perm Perm(this IDomainSource random, uint n)
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
        public static IEnumerable<Perm> Perms(this IDomainSource random, int len)
        {
            while(true)
                yield return random.Perm(len);
        }

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        static NatPerm<N> Shuffle22<N>(NatPerm<N> perm, IDomainSource random)
            where N : unmanaged, ITypeNat
        {
            shuffle(perm, random);
            return perm;
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
        public static NatPerm<N> Perm<N>(this IDomainSource random, N n = default)
            where N : unmanaged, ITypeNat
                => Shuffle22(Z0.Permute.natural(n), random);

        /// <summary>
        /// Produces a stream of random permutation of natural length N
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The length representative</param>
        /// <param name="rep">A primal type representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal symbol type</typeparam>
        public static IEnumerable<NatPerm<N>> Perms<N>(this IDomainSource random, N n = default)
            where N : unmanaged, ITypeNat
        {
            while(true)
                yield return random.Perm(n);
        }

        /// <summary>
        /// Shuffles a copy of the source permutation, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        [MethodImpl(Inline)]
        public static Perm Shuffle(this IDomainSource random, in Perm src)
        {
            var copy = src.Replicate();
            shuffle(copy, random);
            return copy;
        }

        /// <summary>
        /// Shuffles a copy of the source permutation, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        /// <typeparam name="N">The permutation length</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> Shuffle<N>(this IDomainSource random, in NatPerm<N> src)
            where N : unmanaged, ITypeNat
        {
            var copy = src.Replicate();
            shuffle(copy, random);
            return copy;
        }

        /// <summary>
        /// Shuffles the permutation in-place using a provided random source.
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        static ref readonly Perm shuffle(in Perm src, IDomainSource random)
        {
            random.Shuffle(src.Terms);
            return ref src;
        }
    }
}