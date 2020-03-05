//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Nats;

    public static partial class PermX
    {
        /// <summary>
        /// Computes the digits corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static NatSpan<N4, byte> ToDigits(this Perm4L src)
            => permute.digits(src);

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static NatSpan<N8, OctalDigit> ToDigits(this Perm8L src)
            => permute.digits(src);

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static NatSpan<N16, HexDigit> ToDigits(this Perm16L src)
            => permute.digits(src);

        [MethodImpl(Inline)]
        public static Perm16 ToPermSpec(this Vector128<byte> src)
            => Perm16.from(src);

        [MethodImpl(Inline)]
        public static Perm32 ToPermSpec(this Vector256<byte> src)
            => Perm32.from(src);

        /// <summary>
        /// Defines a shuffle spec from a permutation
        /// </summary>
        /// <param name="src">The defining permutation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> ToShuffleSpec(this NatPerm<N16> src)
        {
            var data = src.Terms.Convert<byte>();
            return gvec.vload(n128,in head(data));
        }
    }
}