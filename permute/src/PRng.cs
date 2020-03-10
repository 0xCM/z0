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

    using static Root;


    public static class PRngX
    {

        /// <summary>
        /// Produces a random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static Perm Perm(this IPolyrand random, int n)
            => Permute.identity(n).Shuffle(random);

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
                => Z0.Permute.natural(n).Shuffle(random);
                
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

        /// <summary>
        /// Shuffles a copy of the source permutation, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        [MethodImpl(Inline)]
        public static Perm Shuffle(this IPolyrand random, in Perm src)
        {
            var copy = src.Replicate();
            copy.Shuffle(random);
            return copy;
        }

        /// <summary>
        /// Shuffles a copy of the source permutatiion, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        /// <typeparam name="N">The permutation length</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> Shuffle<N>(this IPolyrand random, in NatPerm<N> src)
            where N : unmanaged, ITypeNat
        {
            var copy = src.Replicate();
            copy.Shuffle(random);
            return copy;
        }

    }
}
