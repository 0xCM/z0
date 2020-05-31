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
        [MethodImpl(Inline), Op]
        public static ref readonly NatSpan<N4,byte> digits(Perm4L src, in NatSpan<N4,byte> dst)
        {
            var scalar = (byte)src;
            dst[0] = SymBits.extract(scalar, 0, 1);
            dst[1] = SymBits.extract(scalar, 2, 3);
            dst[2] = SymBits.extract(scalar, 4, 5);
            dst[3] = SymBits.extract(scalar, 6, 7);
            return ref dst;
        }

        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N4,byte> digits(Perm4L src)
            => digits(src,NatSpan.alloc<N4,byte>());

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static ref readonly NatSpan<N8, OctalDigit> digits(Perm8L src, in NatSpan<N8, OctalDigit> dst)
        {
            //[0 1 2 | 3 4 5 | 6 7 8 | ... | 21 22 23] -> 256x32
            var scalar = (uint)src;
            dst[0] = (OctalDigit)SymBits.extract(scalar, 0, 2);
            dst[1] = (OctalDigit)SymBits.extract(scalar, 3, 5);
            dst[2] = (OctalDigit)SymBits.extract(scalar, 6, 8);
            dst[3] = (OctalDigit)SymBits.extract(scalar, 9, 11);
            dst[4] = (OctalDigit)SymBits.extract(scalar, 12, 14);
            dst[5] = (OctalDigit)SymBits.extract(scalar, 15, 17);
            dst[6] = (OctalDigit)SymBits.extract(scalar, 18, 20);
            dst[7] = (OctalDigit)SymBits.extract(scalar, 21, 23);
            return ref dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N8, OctalDigit> digits(Perm8L src)
            => digits(src,NatSpan.alloc<N8,OctalDigit>());            

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static ref readonly NatSpan<N16,HexDigit> digits(Perm16L src, in NatSpan<N16,HexDigit> dst)
        {
            var scalar = (ulong)src;
            dst[0] = (HexDigit)SymBits.extract(scalar, 0, 3);
            dst[1] = (HexDigit)SymBits.extract(scalar, 4, 7);
            dst[2] = (HexDigit)SymBits.extract(scalar, 8, 11);
            dst[3] = (HexDigit)SymBits.extract(scalar, 12, 15);
            dst[4] = (HexDigit)SymBits.extract(scalar, 16, 19);
            dst[5] = (HexDigit)SymBits.extract(scalar, 20, 23);
            dst[6] = (HexDigit)SymBits.extract(scalar, 24, 27);
            dst[7] = (HexDigit)SymBits.extract(scalar, 28, 31);
            dst[8] = (HexDigit)SymBits.extract(scalar, 32, 35);
            dst[9] = (HexDigit)SymBits.extract(scalar, 36, 39);
            dst[10] = (HexDigit)SymBits.extract(scalar, 40, 43);
            dst[11] = (HexDigit)SymBits.extract(scalar, 44, 47);
            dst[12] = (HexDigit)SymBits.extract(scalar, 48, 53);
            dst[13] = (HexDigit)SymBits.extract(scalar, 52, 55);
            dst[14] = (HexDigit)SymBits.extract(scalar, 56, 59);
            dst[15] = (HexDigit)SymBits.extract(scalar, 60, 63);
            return ref dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N16,HexDigit> digits(Perm16L src)
            => digits(src, NatSpan.alloc<N16,HexDigit>());

        [MethodImpl(Inline), Op]
        public static Vector128<byte> shuffles(NatPerm<N16> src)
            => Vectors.vload(n128, refs.head(src.Terms.To<byte>()));

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec as
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> digits(Perm16 spec)
            => dvec.vshuf16x8(Data.vincrements<byte>(n128), spec.data);

        /// <summary>
        /// Computes the digits corresponding to each 5-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> digits(Perm32 spec)
            => dvec.vshuf32x8(Data.vincrements<byte>(n256),spec.data);
    }
}