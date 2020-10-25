//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using B = BinaryDigit;
    using D = DecimalDigit;
    using X = HexDigit;

    using BS = BinarySym;
    using HSL = HexSymLo;
    using HSU = HexSymUp;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static Span<D> digits(ReadOnlySpan<char> src, Span<D> dst)
        {
            var len = src.Length;
            for(var i=0u; i< len; i++)
                seek(dst,i) = digit(base10, skip(src,i));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSL> src, Span<X> dst)
        {
            var len = src.Length;
            for(var i=0u; i<len; i++)
                seek(dst,i) = digit(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSU> src, Span<X> dst)
        {
            var len = src.Length;
            for(var i=0u; i<len; i++)
                seek(dst,i) = digit(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static Span<D> digits(Base10 @base, ulong src)
        {
            var data = src.ToString();
            var dst = sys.alloc<D>(data.Length);
            return digits(data, dst);
        }

        [MethodImpl(Inline), Op]
        public static void digits(byte src, Span<B> dst)
        {
            seek(dst,0) = (B)((0b00000001 & src) >> 0);
            seek(dst,1) = (B)((0b00000010 & src) >> 1);
            seek(dst,2) = (B)((0b00000100 & src) >> 2);
            seek(dst,3) = (B)((0b00001000 & src) >> 3);
            seek(dst,4) = (B)((0b00010000 & src) >> 4);
            seek(dst,5) = (B)((0b00100000 & src) >> 5);
            seek(dst,6) = (B)((0b01000000 & src) >> 6);
            seek(dst,7) = (B)((0b10000000 & src) >> 7);
        }

        [MethodImpl(Inline), Op]
        public static void digits(ushort src, Span<B> dst)
        {
            digits((byte)src, dst);
            digits((byte)(src >> 8), dst.Slice(8));
        }

        [MethodImpl(Inline), Op]
        public static void digits(uint src, Span<B> dst)
        {
            digits((ushort)src,dst);
            digits((ushort)(src >> 16),dst.Slice(16));
        }

        [MethodImpl(Inline), Op]
        public static void digits(ulong src, Span<B> dst)
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
            seek(dst,0) = z.extract(scalar, 0, 1);
            seek(dst,1) = z.extract(scalar, 2, 3);
            seek(dst,2) = z.extract(scalar, 4, 5);
            seek(dst,3) = z.extract(scalar, 6, 7);
            return dst;
        }

        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static ref readonly NatSpan<N4,byte> digits(Perm4L src, in NatSpan<N4,byte> dst)
        {
            var scalar = (byte)src;
            dst[0] = z.extract(scalar, 0, 1);
            dst[1] = z.extract(scalar, 2, 3);
            dst[2] = z.extract(scalar, 4, 5);
            dst[3] = z.extract(scalar, 6, 7);
            return ref dst;
        }

        /// <summary>
        /// Computes the digigs corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N4,byte> digits(Perm4L src)
            => digits(src,NatSpan.alloc<N4,byte>());



        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<BS> src, Span<B> dst)
        {
            var len = src.Length;
            for(var i=0u; i<len; i++)
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
            seek(dst,0) = (OctalDigit)z.extract(scalar, 0, 2);
            seek(dst,1) = (OctalDigit)z.extract(scalar, 3, 5);
            seek(dst,2) = (OctalDigit)z.extract(scalar, 6, 8);
            seek(dst,3) = (OctalDigit)z.extract(scalar, 9, 11);
            seek(dst,4) = (OctalDigit)z.extract(scalar, 12, 14);
            seek(dst,5) = (OctalDigit)z.extract(scalar, 15, 17);
            seek(dst,6) = (OctalDigit)z.extract(scalar, 18, 20);
            seek(dst,7) = (OctalDigit)z.extract(scalar, 21, 23);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static ref readonly NatSpan<N8, OctalDigit> digits(Perm8L src, in NatSpan<N8,OctalDigit> dst)
        {
            //[0 1 2 | 3 4 5 | 6 7 8 | ... | 21 22 23] -> 256x32
            var scalar = (uint)src;
            dst[0] = (OctalDigit)z.extract(scalar, 0, 2);
            dst[1] = (OctalDigit)z.extract(scalar, 3, 5);
            dst[2] = (OctalDigit)z.extract(scalar, 6, 8);
            dst[3] = (OctalDigit)z.extract(scalar, 9, 11);
            dst[4] = (OctalDigit)z.extract(scalar, 12, 14);
            dst[5] = (OctalDigit)z.extract(scalar, 15, 17);
            dst[6] = (OctalDigit)z.extract(scalar, 18, 20);
            dst[7] = (OctalDigit)z.extract(scalar, 21, 23);
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
        public static Span<HexDigit> digits(Perm16L src, Span<X> dst)
        {
            var scalar = (ulong)src;
            seek(dst,0) = (X)z.extract(scalar, 0, 3);
            seek(dst,1) = (X)z.extract(scalar, 4, 7);
            seek(dst,2) = (X)z.extract(scalar, 8, 11);
            seek(dst,3) = (X)z.extract(scalar, 12, 15);
            seek(dst,4) = (X)z.extract(scalar, 16, 19);
            seek(dst,5) = (X)z.extract(scalar, 20, 23);
            seek(dst,6) = (X)z.extract(scalar, 24, 27);
            seek(dst,7) = (X)z.extract(scalar, 28, 31);
            seek(dst,8) = (X)z.extract(scalar, 32, 35);
            seek(dst,9) = (X)z.extract(scalar, 36, 39);
            seek(dst,10) = (X)z.extract(scalar, 40, 43);
            seek(dst,11) = (X)z.extract(scalar, 44, 47);
            seek(dst,12) = (X)z.extract(scalar, 48, 53);
            seek(dst,13) = (X)z.extract(scalar, 52, 55);
            seek(dst,14) = (X)z.extract(scalar, 56, 59);
            seek(dst,15) = (X)z.extract(scalar, 60, 63);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline)]
        public static ref readonly NatSpan<N16,X> digits(Perm16L src, in NatSpan<N16,X> dst)
        {
            var scalar = (ulong)src;
            dst[0] = (X)z.extract(scalar, 0, 3);
            dst[1] = (X)z.extract(scalar, 4, 7);
            dst[2] = (X)z.extract(scalar, 8, 11);
            dst[3] = (X)z.extract(scalar, 12, 15);
            dst[4] = (X)z.extract(scalar, 16, 19);
            dst[5] = (X)z.extract(scalar, 20, 23);
            dst[6] = (X)z.extract(scalar, 24, 27);
            dst[7] = (X)z.extract(scalar, 28, 31);
            dst[8] = (X)z.extract(scalar, 32, 35);
            dst[9] = (X)z.extract(scalar, 36, 39);
            dst[10] = (X)z.extract(scalar, 40, 43);
            dst[11] = (X)z.extract(scalar, 44, 47);
            dst[12] = (X)z.extract(scalar, 48, 53);
            dst[13] = (X)z.extract(scalar, 52, 55);
            dst[14] = (X)z.extract(scalar, 56, 59);
            dst[15] = (X)z.extract(scalar, 60, 63);
            return ref dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N16,X> digits(Perm16L src)
            => digits(src, NatSpan.alloc<N16,X>());
    }
}