//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class Perms
    {
        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N4, byte> digits(Perm4L src)
        {
            var scalar = (byte)src;
            var dst = NatSpan.alloc<N4,byte>();
            dst[0] = gbits.between(scalar, 0, 1);
            dst[1] = gbits.between(scalar, 2, 3);
            dst[2] = gbits.between(scalar, 4, 5);
            dst[3] = gbits.between(scalar, 6, 7);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N8, OctalDigit> digits(Perm8L src)
        {
            //[0 1 2 | 3 4 5 | 6 7 8 | ... | 21 22 23] -> 256x32
            var scalar = (uint)src;
            var dst = NatSpan.alloc<N8,OctalDigit>();
            dst[0] = (OctalDigit)gbits.between(scalar, 0, 2);
            dst[1] = (OctalDigit)gbits.between(scalar, 3, 5);
            dst[2] = (OctalDigit)gbits.between(scalar, 6, 8);
            dst[3] = (OctalDigit)gbits.between(scalar, 9, 11);
            dst[4] = (OctalDigit)gbits.between(scalar, 12, 14);
            dst[5] = (OctalDigit)gbits.between(scalar, 15, 17);
            dst[6] = (OctalDigit)gbits.between(scalar, 18, 20);
            dst[7] = (OctalDigit)gbits.between(scalar, 21, 23);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N16, HexDigit> digits(Perm16L src)
        {
            var scalar = (ulong)src;
            var dst = NatSpan.alloc<N16,HexDigit>();
            dst[0] = (HexDigit)gbits.between(scalar, 0, 3);
            dst[1] = (HexDigit)gbits.between(scalar, 4, 7);
            dst[2] = (HexDigit)gbits.between(scalar, 8, 11);
            dst[3] = (HexDigit)gbits.between(scalar, 12, 15);
            dst[4] = (HexDigit)gbits.between(scalar, 16, 19);
            dst[5] = (HexDigit)gbits.between(scalar, 20, 23);
            dst[6] = (HexDigit)gbits.between(scalar, 24, 27);
            dst[7] = (HexDigit)gbits.between(scalar, 28, 31);
            dst[8] = (HexDigit)gbits.between(scalar, 32, 35);
            dst[9] = (HexDigit)gbits.between(scalar, 36, 39);
            dst[10] = (HexDigit)gbits.between(scalar, 40, 43);
            dst[11] = (HexDigit)gbits.between(scalar, 44, 47);
            dst[12] = (HexDigit)gbits.between(scalar, 48, 53);
            dst[13] = (HexDigit)gbits.between(scalar, 52, 55);
            dst[14] = (HexDigit)gbits.between(scalar, 56, 59);
            dst[15] = (HexDigit)gbits.between(scalar, 60, 63);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec as
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> digits(Perm16 spec)
            => dinx.vshuf16x8(CpuVector.vincrements<byte>(n128), spec.data);

        /// <summary>
        /// Computes the digits corresponding to each 5-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> digits(Perm32 spec)
            => dinx.vshuf32x8(CpuVector.vincrements<byte>(n256),spec.data);

    }
}