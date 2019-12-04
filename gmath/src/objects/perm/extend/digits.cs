//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    partial class PermX
    {
        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N4, byte> Digits(this Perm4 src)
        {
            var scalar = (byte)src;
            var dst = NatSpan.alloc<N4,byte>();
            dst[0] = BitMask.between(scalar, 0, 1);
            dst[1] = BitMask.between(scalar, 2, 3);
            dst[2] = BitMask.between(scalar, 4, 5);
            dst[3] = BitMask.between(scalar, 6, 7);
            return dst;
        }

        public static NatSpan<N16, HexDigit> Digits(this Perm16 src)
        {
            var scalar = (ulong)src;
            var dst = NatSpan.alloc<N16,HexDigit>();
            dst[0] = (HexDigit)BitMask.between(scalar, 0, 3);
            dst[1] = (HexDigit)BitMask.between(scalar, 4, 7);
            dst[2] = (HexDigit)BitMask.between(scalar, 8, 11);
            dst[3] = (HexDigit)BitMask.between(scalar, 12, 15);
            dst[4] = (HexDigit)BitMask.between(scalar, 16, 19);
            dst[5] = (HexDigit)BitMask.between(scalar, 20, 23);
            dst[6] = (HexDigit)BitMask.between(scalar, 24, 27);
            dst[7] = (HexDigit)BitMask.between(scalar, 28, 31);
            dst[8] = (HexDigit)BitMask.between(scalar, 32, 35);
            dst[9] = (HexDigit)BitMask.between(scalar, 36, 39);
            dst[10] = (HexDigit)BitMask.between(scalar, 40, 43);
            dst[11] = (HexDigit)BitMask.between(scalar, 44, 47);
            dst[12] = (HexDigit)BitMask.between(scalar, 48, 53);
            dst[13] = (HexDigit)BitMask.between(scalar, 52, 55);
            dst[14] = (HexDigit)BitMask.between(scalar, 56, 59);
            dst[15] = (HexDigit)BitMask.between(scalar, 60, 63);
            return dst;
        }
    }

}