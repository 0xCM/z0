//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class permute
    {
        /// <summary>
        /// Reifies a permutation of length 8 from its canonical scalar specification
        /// </summary>
        /// <param name="spec">The representative</param>
        public static NatPerm<N4> natural(Perm4L spec)
        {
            uint data = (byte)spec;
            var dst = NatPerm<N4>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=2)
                dst[i] = (int)gbits.between(data, (byte)offset, (byte)(offset + 1));
            return dst;
        }

        /// <summary>
        /// Reifies a permutation of length 8 from its canonical scalar specification
        /// </summary>
        /// <param name="spec">The representative</param>
        public static NatPerm<N8> natural(Perm8L spec)
        {
            uint data = (uint)spec;
            var dst = NatPerm<N8>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=3)
                dst[i] = (int)gbits.between(data, (byte)offset, (byte)(offset + 2));
            return dst;
        }

        /// <summary>
        /// Reifies a permutation of length 16 from its canonical scalar representative 
        /// </summary>
        /// <param name="spec">The representative</param>
        public static NatPerm<N16> natural(Perm16L spec)
        {
            ulong data = (ulong)spec;
            var dst = NatPerm<N16>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=4)
                dst[i] = (int)gbits.between(data, (byte)offset, (byte)(offset + 3));
            return dst;
        }

        /// <summary>
        /// Creates a new identity permutation of natural length
        /// </summary>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The term type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatPerm<N>.Identity.Replicate();

        /// <summary>
        /// Defines an identity permutation of natural length and applies a specified sequence of transpostions
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(N n, params NatSwap<N>[] swaps)
            where N : unmanaged, ITypeNat
                => new NatPerm<N>(swaps);

        /// <summary>
        /// Defines an identity permutation of natural length and applies a specified sequence of transpostions
        /// </summary>
        /// <param name="length">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(params NatSwap<N>[] swaps)
            where N : unmanaged, ITypeNat
                => new NatPerm<N>(swaps);

        /// <summary>
        /// Defines a permutation of natural length
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that define the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(N n, ReadOnlySpan<int> terms)
            where N : unmanaged, ITypeNat
                => new NatPerm<N>(terms.ToArray());

        /// <summary>
        /// Defines a permutation of natural length
        /// </summary>
        /// <param name="n">The length of the permutation</param>
        /// <param name="terms">The ordered sequence of terms that specify the permutation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The symbol type</typeparam>
        [MethodImpl(Inline)]
        public static NatPerm<N> natural<N>(N n, params int[] terms)
            where N : unmanaged, ITypeNat
                => new NatPerm<N>(terms);

        public static NatPerm<N,T> natural<N,T>(N n, ReadOnlySpan<T> terms)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(terms.Length != natval(n))
                Errors.ThrowInvariantFailure($"{n} != {terms.Length}");
            return new NatPerm<N,T>(define(terms));
        }

        public static NatPerm<N,T> natural<N,T>(N n, Span<T> terms)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natural(n, terms.ReadOnly());
    }
}