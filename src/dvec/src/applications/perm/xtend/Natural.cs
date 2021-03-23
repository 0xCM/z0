//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;

    using static Part;

    using api = Permute;

    public static partial class PermX
    {
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

        public static NatPerm<N4> ToNatural(this Perm4L src)
            => api.natural(src);

        public static NatPerm<N8> ToNatural(this Perm8L src)
            => api.natural(src);

        public static NatPerm<N16> ToNatural(this Perm16L src)
            => api.natural(src);

        /// <summary>
        /// Shuffles bitstring content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        public static BitString Permute(this BitString src, Perm p)
        {
            var dst = BitString.alloc(p.Length);
            for(var i = 0; i < p.Length; i++)
                dst[i] = src[p[i]];
            return dst;
        }

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 4 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm4L ToLiteral(this NatPerm<N4> src)
            => NatPerm.pack(src);

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 8 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm8L ToLiteral(this NatPerm<N8> src)
            => NatPerm.pack(src);

        /// <summary>
        /// Constructs the canonical literal representation of a natural permutation on 16 symbols
        /// </summary>
        /// <param name="src">The natural permutation</param>
        [MethodImpl(Inline)]
        public static Perm16L ToLiteral(this NatPerm<N16> src)
            => NatPerm.pack(src);

        /// <summary>
        /// Defines a shuffle spec from a permutation
        /// </summary>
        /// <param name="src">The defining permutation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> ToShuffleSpec(this NatPerm<N16> src)
            => NatPerm.shuffles(src);
    }
}