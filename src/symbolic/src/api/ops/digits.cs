//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    using HSL = HexSymLo;
    using HSU = HexSymUp;

    partial class Symbolic        
    {        
        [MethodImpl(Inline), Op]
        public static Span<DeciDigit> digits(ReadOnlySpan<char> src, Span<DeciDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i< len; i++)
                dst[i] = Symbolic.digit(Seed.base10, src[i]);            
            return dst;            
        }

        public static Span<DeciDigit> digits(Base10 @base, ulong src)
        {
            var data = src.ToString();
            var dst = new DeciDigit[data.Length];
            return digits(data, dst);
        }

        [MethodImpl(Inline), Op]
        public static void digits(byte src, Span<BinaryDigit> dst)
        {
            seek(dst,0) = (BinaryDigit)((0b00000001 & src) >> 0);
            seek(dst,1) = (BinaryDigit)((0b00000010 & src) >> 1);
            seek(dst,2) = (BinaryDigit)((0b00000100 & src) >> 2);
            seek(dst,3) = (BinaryDigit)((0b00001000 & src) >> 3);
            seek(dst,4) = (BinaryDigit)((0b00010000 & src) >> 4);
            seek(dst,5) = (BinaryDigit)((0b00100000 & src) >> 5);
            seek(dst,6) = (BinaryDigit)((0b01000000 & src) >> 6);
            seek(dst,7) = (BinaryDigit)((0b10000000 & src) >> 7);
        }

        [MethodImpl(Inline), Op]
        public static void digits(ushort src, Span<BinaryDigit> dst)
        {
            digits((byte)src, dst);
            digits((byte)(src >> 8), dst.Slice(8));
        }

        [MethodImpl(Inline), Op]
        public static void digits(uint src, Span<BinaryDigit> dst)
        {
            digits((ushort)src,dst);
            digits((ushort)(src >> 16),dst.Slice(16));
        }

        [MethodImpl(Inline), Op]
        public static void digits(ulong src, Span<BinaryDigit> dst)
        {
            digits((uint)src,dst);
            digits((uint)(src >> 32), dst.Slice(32));
        }

        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<byte> digits(Perm4L src, Span<byte> dst)
        {
            var scalar = (byte)src;
            seek(dst,0) = SymBits.extract(scalar, 0, 1);
            seek(dst,1) = SymBits.extract(scalar, 2, 3);
            seek(dst,2) = SymBits.extract(scalar, 4, 5);
            seek(dst,3) = SymBits.extract(scalar, 6, 7);
            return dst;
        }

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
        [MethodImpl(Inline), Op]
        public static NatSpan<N4,byte> digits(Perm4L src)
            => digits(src,NatSpan.alloc<N4,byte>());


        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSL> src, Span<HexDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSU> src, Span<HexDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<BinarySym> src, Span<BinaryDigit> dst)
        {
            var len = src.Length;
            for(var i = 0; i<len; i++)
                seek(dst,i) = digit(skip(src,i));            
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<OctalDigit> digits(Perm8L src, Span<OctalDigit> dst)
        {
            //[0 1 2 | 3 4 5 | 6 7 8 | ... | 21 22 23] -> 256x32
            var scalar = (uint)src;
            seek(dst,0) = (OctalDigit)SymBits.extract(scalar, 0, 2);
            seek(dst,1) = (OctalDigit)SymBits.extract(scalar, 3, 5);
            seek(dst,2) = (OctalDigit)SymBits.extract(scalar, 6, 8);
            seek(dst,3) = (OctalDigit)SymBits.extract(scalar, 9, 11);
            seek(dst,4) = (OctalDigit)SymBits.extract(scalar, 12, 14);
            seek(dst,5) = (OctalDigit)SymBits.extract(scalar, 15, 17);
            seek(dst,6) = (OctalDigit)SymBits.extract(scalar, 18, 20);
            seek(dst,7) = (OctalDigit)SymBits.extract(scalar, 21, 23);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static ref readonly NatSpan<N8, OctalDigit> digits(Perm8L src, in NatSpan<N8,OctalDigit> dst)
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
        public static Span<HexDigit> digits(Perm16L src, Span<HexDigit> dst)
        {
            var scalar = (ulong)src;
            seek(dst,0) = (HexDigit)SymBits.extract(scalar, 0, 3);
            seek(dst,1) = (HexDigit)SymBits.extract(scalar, 4, 7);
            seek(dst,2) = (HexDigit)SymBits.extract(scalar, 8, 11);
            seek(dst,3) = (HexDigit)SymBits.extract(scalar, 12, 15);
            seek(dst,4) = (HexDigit)SymBits.extract(scalar, 16, 19);
            seek(dst,5) = (HexDigit)SymBits.extract(scalar, 20, 23);
            seek(dst,6) = (HexDigit)SymBits.extract(scalar, 24, 27);
            seek(dst,7) = (HexDigit)SymBits.extract(scalar, 28, 31);
            seek(dst,8) = (HexDigit)SymBits.extract(scalar, 32, 35);
            seek(dst,9) = (HexDigit)SymBits.extract(scalar, 36, 39);
            seek(dst,10) = (HexDigit)SymBits.extract(scalar, 40, 43);
            seek(dst,11) = (HexDigit)SymBits.extract(scalar, 44, 47);
            seek(dst,12) = (HexDigit)SymBits.extract(scalar, 48, 53);
            seek(dst,13) = (HexDigit)SymBits.extract(scalar, 52, 55);
            seek(dst,14) = (HexDigit)SymBits.extract(scalar, 56, 59);
            seek(dst,15) = (HexDigit)SymBits.extract(scalar, 60, 63);
            return dst;
        }        

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
    }
}