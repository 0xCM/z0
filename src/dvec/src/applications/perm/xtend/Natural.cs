//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using api = Permute;

    public static partial class PermX
    {
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
        /// Computes the digits corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static Span<byte> ToDigits(this Perm4L src)
            => Digital.digits(src);

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static Span<OctalDigit> ToDigits(this Perm8L src)
            => Digital.digits(src);

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static Span<HexDigit> ToDigits(this Perm16L src)
            => Digital.digits(src);

        /// <summary>
        /// Defines a shuffle spec from a permutation
        /// </summary>
        /// <param name="src">The defining permutation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> ToShuffleSpec(this NatPerm<N16> src)
            => api.shuffles(src);
    }
}