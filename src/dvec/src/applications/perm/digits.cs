//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    partial class Permute
    {
        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N4, byte> digits(Perm4L src)
        {
            var scalar = (byte)src;
            var dst = NatSpan.alloc<N4,byte>();
            dst[0] = gbits.bitseg(scalar, 0, 1);
            dst[1] = gbits.bitseg(scalar, 2, 3);
            dst[2] = gbits.bitseg(scalar, 4, 5);
            dst[3] = gbits.bitseg(scalar, 6, 7);
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
            dst[0] = (OctalDigit)gbits.bitseg(scalar, 0, 2);
            dst[1] = (OctalDigit)gbits.bitseg(scalar, 3, 5);
            dst[2] = (OctalDigit)gbits.bitseg(scalar, 6, 8);
            dst[3] = (OctalDigit)gbits.bitseg(scalar, 9, 11);
            dst[4] = (OctalDigit)gbits.bitseg(scalar, 12, 14);
            dst[5] = (OctalDigit)gbits.bitseg(scalar, 15, 17);
            dst[6] = (OctalDigit)gbits.bitseg(scalar, 18, 20);
            dst[7] = (OctalDigit)gbits.bitseg(scalar, 21, 23);
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
            dst[0] = (HexDigit)gbits.bitseg(scalar, 0, 3);
            dst[1] = (HexDigit)gbits.bitseg(scalar, 4, 7);
            dst[2] = (HexDigit)gbits.bitseg(scalar, 8, 11);
            dst[3] = (HexDigit)gbits.bitseg(scalar, 12, 15);
            dst[4] = (HexDigit)gbits.bitseg(scalar, 16, 19);
            dst[5] = (HexDigit)gbits.bitseg(scalar, 20, 23);
            dst[6] = (HexDigit)gbits.bitseg(scalar, 24, 27);
            dst[7] = (HexDigit)gbits.bitseg(scalar, 28, 31);
            dst[8] = (HexDigit)gbits.bitseg(scalar, 32, 35);
            dst[9] = (HexDigit)gbits.bitseg(scalar, 36, 39);
            dst[10] = (HexDigit)gbits.bitseg(scalar, 40, 43);
            dst[11] = (HexDigit)gbits.bitseg(scalar, 44, 47);
            dst[12] = (HexDigit)gbits.bitseg(scalar, 48, 53);
            dst[13] = (HexDigit)gbits.bitseg(scalar, 52, 55);
            dst[14] = (HexDigit)gbits.bitseg(scalar, 56, 59);
            dst[15] = (HexDigit)gbits.bitseg(scalar, 60, 63);
            return dst;
        }

    }
}