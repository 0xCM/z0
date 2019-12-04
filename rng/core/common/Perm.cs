//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class RngX
    {
        /// <summary>
        /// Produces a random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static PermSpec Perm(this IPolyrand random, int n)
            => Z0.Perm.identity(n).Shuffle(random);

        /// <summary>
        /// Produces a random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static PermSpec Perm(this IPolyrand random, uint n)
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
        public static IEnumerable<PermSpec> Perms(this IPolyrand random, int len)
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
                => Z0.Perm.natural(n).Shuffle(random);
                
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