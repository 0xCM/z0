//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using B = BinaryDigit;
    using D = DecimalDigit;
    using X = HexDigit;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    partial struct Digital
    {
         /// <summary>
        /// Encodes two decimal digits d := 0x[c1][c0] for characters c2, c1 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c1">The source for digit 1, the most significant digit</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline), Op]
        public static ulong digits(Base10 @base, char c1, char c0)
            => pack(@base10, c1, c0);

        /// <summary>
        /// Encodes three decimal digits d := 0x[c2][c1][c0] for characters c2, c1, c0 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c2">The source for digit 2, the most significant digit</param>
        /// <param name="c1">The source for digit 1</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline), Op]
        public static ulong digits(Base10 @base, char c2, char c1, char c0)
            => pack(@base10, c2, c1, c0);

        /// <summary>
        /// Encodes four decimal digits d := 0x[c3][c2][c1][c0] for characters c3, c2, c1, c0 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c3">The source for digit 3, the most significant digit</param>
        /// <param name="c2">The source for digit 2</param>
        /// <param name="c1">The source for digit 1</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline), Op]
        public static ulong digits(Base10 @base, char c3, char c2, char c1, char c0)
            => pack(@base10, c3, c2, c1, c0);

        /// <summary>
        /// Encodes five decimal digits d := 0x[c4][c3][c2][c1][c0] for characters c4, c3, c2, c1, c0 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c4">The source for digit 4, the most significant digit</param>
        /// <param name="c3">The source for digit 3</param>
        /// <param name="c2">The source for digit 2</param>
        /// <param name="c1">The source for digit 1</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline), Op]
        public static ulong digits(Base10 @base, char c4, char c3, char c2, char c1, char c0)
            => pack(@base10, c4, c3, c2, c1, c0);

        /// <summary>
        /// Encodes eight decimal digits d := 0x[c7][c6][c5][c4][c3][c2][c1][c0] for characters c7, c6, c5, c4, c3, c2, c1, c0 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c7">The source for digit 7, the most significant digit</param>
        /// <param name="c6">The source for digit 6</param>
        /// <param name="c5">The source for digit 5</param>
        /// <param name="c4">The source for digit 4</param>
        /// <param name="c3">The source for digit 3</param>
        /// <param name="c2">The source for digit 2</param>
        /// <param name="c1">The source for digit 1</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline), Op]
        public static ulong digits(Base10 @base, char c7, char c6, char c5, char c4, char c3, char c2, char c1, char c0)
            => pack(@base10, c7, c6, c5, c4, c3, c2, c1, c0);

        /// <summary>
        /// Extracts two encoded digits
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="d1">The most significant digit</param>
        /// <param name="d0">The least significant digit</param>
        [MethodImpl(Inline), Op]
        public static void digits(ulong src, out byte d1, out byte d0)
        {
            d1 = (byte)digit(src,1);
            d0 = (byte)digit(src,0);
        }

        [MethodImpl(Inline), Op]
        public static void digits(ulong src, out byte d2, out byte d1, out byte d0)
        {
            d2 = (byte)digit(src,2);
            d1 = (byte)digit(src,1);
            d0 = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first digit from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="n">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline), Op]
        public static void digits(ulong src, N1 n, ref byte dst)
            => add(dst, 0) = (byte)digit(src,0);

        /// <summary>
        /// Extracts the first two digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="n">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline), Op]
        public static void digits(ulong src, N2 n, ref byte dst)
        {
            add(dst, 1) = (byte)digit(src,1);
            add(dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first three digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="n">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline), Op]
        public static void digits(ulong src, N3 n, ref byte dst)
        {
            add(dst, 2) = (byte)digit(src,2);
            add(dst, 1) = (byte)digit(src,1);
            add(dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first four digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="n">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline), Op]
        public static void digits(ulong src, N4 n, ref byte dst)
        {
            add(dst, 3) = (byte)digit(src,3);
            add(dst, 2) = (byte)digit(src,2);
            add(dst, 1) = (byte)digit(src,1);
            add(dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first five digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="n">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline), Op]
        public static void digits(ulong src, N5 n, ref byte dst)
        {
            add(dst, 4) = (byte)digit(src,4);
            add(dst, 3) = (byte)digit(src,3);
            add(dst, 2) = (byte)digit(src,2);
            add(dst, 1) = (byte)digit(src,1);
            add(dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first six digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="n">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline), Op]
        public static void digits(ulong src, N6 n, ref byte dst)
        {
            add(dst, 5) = (byte)digit(src,5);
            add(dst, 4) = (byte)digit(src,4);
            add(dst, 3) = (byte)digit(src,3);
            add(dst, 2) = (byte)digit(src,2);
            add(dst, 1) = (byte)digit(src,1);
            add(dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first seven digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="n">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline), Op]
        public static void digits(ulong src, N7 n, ref byte dst)
        {
            add(dst, 6) = (byte)digit(src,6);
            add(dst, 5) = (byte)digit(src,5);
            add(dst, 4) = (byte)digit(src,4);
            add(dst, 3) = (byte)digit(src,3);
            add(dst, 2) = (byte)digit(src,2);
            add(dst, 1) = (byte)digit(src,1);
            add(dst, 0) = (byte)digit(src,0);
        }

        [MethodImpl(Inline), Op]
        public static Span<DecimalDigit> digits(ReadOnlySpan<char> src, Span<DecimalDigit> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = Digital.digit(base10, skip(src,i));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HexSymLo> src, Span<HexDigit> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = Digital.digit(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HexSymUp> src, Span<HexDigit> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = Digital.digit(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static Span<D> digits(Base10 @base, ulong src)
        {
            var data = src.ToString();
            var dst = sys.alloc<D>(data.Length);
            return digits(data, dst);
        }

        [MethodImpl(Inline), Op]
        public static void digits(byte src, Span<BinaryDigit> dst)
        {
            seek(dst, 0) = (BinaryDigit)((0b00000001 & src) >> 0);
            seek(dst, 1) = (BinaryDigit)((0b00000010 & src) >> 1);
            seek(dst, 2) = (BinaryDigit)((0b00000100 & src) >> 2);
            seek(dst, 3) = (BinaryDigit)((0b00001000 & src) >> 3);
            seek(dst, 4) = (BinaryDigit)((0b00010000 & src) >> 4);
            seek(dst, 5) = (BinaryDigit)((0b00100000 & src) >> 5);
            seek(dst, 6) = (BinaryDigit)((0b01000000 & src) >> 6);
            seek(dst, 7) = (BinaryDigit)((0b10000000 & src) >> 7);
        }

        [MethodImpl(Inline), Op]
        public static void digits(ushort src, Span<BinaryDigit> dst)
        {
            digits((byte)src, dst);
            digits((byte)(src >> 8), slice(dst, 8));
        }

        [MethodImpl(Inline), Op]
        public static void digits(uint src, Span<BinaryDigit> dst)
        {
            digits((ushort)src,dst);
            digits((ushort)(src >> 16), slice(dst,16));
        }

        [MethodImpl(Inline), Op]
        public static void digits(ulong src, Span<BinaryDigit> dst)
        {
            digits((uint)src,dst);
            digits((uint)(src >> 32), slice(dst, 32));
        }

        /// <summary>
        /// Computes the digits corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<byte> digits(Perm4L src, Span<byte> dst)
        {
            var scalar = (byte)src;
            seek(dst,0) = BitMasks.extract(scalar, 0, 1);
            seek(dst,1) = BitMasks.extract(scalar, 2, 3);
            seek(dst,2) = BitMasks.extract(scalar, 4, 5);
            seek(dst,3) = BitMasks.extract(scalar, 6, 7);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static ref readonly NatSpan<N4,byte> digits(Perm4L src, in NatSpan<N4,byte> dst)
        {
            var scalar = (byte)src;
            dst[0] = BitMasks.extract(scalar, 0, 1);
            dst[1] = BitMasks.extract(scalar, 2, 3);
            dst[2] = BitMasks.extract(scalar, 4, 5);
            dst[3] = BitMasks.extract(scalar, 6, 7);
            return ref dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N4,byte> digits(Perm4L src)
            => digits(src,NatSpan.alloc<N4,byte>());

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<BinarySym> src, Span<BinaryDigit> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = Digital.digit(skip(src,i));
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<OctalDigit> digits(Perm8L src, Span<OctalDigit> dst)
        {
            return digits((uint)src, dst);
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of a <see cref='uint'/> value
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<OctalDigit> digits(uint src, Span<OctalDigit> dst)
        {
            //[0 1 2 | 3 4 5 | 6 7 8 | ... | 21 22 23] -> 256x32
            seek(dst,0) = (OctalDigit)BitMasks.extract(src, 0, 2);
            seek(dst,1) = (OctalDigit)BitMasks.extract(src, 3, 5);
            seek(dst,2) = (OctalDigit)BitMasks.extract(src, 6, 8);
            seek(dst,3) = (OctalDigit)BitMasks.extract(src, 9, 11);
            seek(dst,4) = (OctalDigit)BitMasks.extract(src, 12, 14);
            seek(dst,5) = (OctalDigit)BitMasks.extract(src, 15, 17);
            seek(dst,6) = (OctalDigit)BitMasks.extract(src, 18, 20);
            seek(dst,7) = (OctalDigit)BitMasks.extract(src, 21, 23);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 3-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static Span<OctalDigit> digits(Perm8L src)
            => digits(src, alloc<OctalDigit>(8));

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Span<HexDigit> digits(Perm16L src, Span<HexDigit> dst)
        {
            var scalar = (ulong)src;
            seek(dst,0) = (X)BitMasks.extract(scalar, 0, 3);
            seek(dst,1) = (X)BitMasks.extract(scalar, 4, 7);
            seek(dst,2) = (X)BitMasks.extract(scalar, 8, 11);
            seek(dst,3) = (X)BitMasks.extract(scalar, 12, 15);
            seek(dst,4) = (X)BitMasks.extract(scalar, 16, 19);
            seek(dst,5) = (X)BitMasks.extract(scalar, 20, 23);
            seek(dst,6) = (X)BitMasks.extract(scalar, 24, 27);
            seek(dst,7) = (X)BitMasks.extract(scalar, 28, 31);
            seek(dst,8) = (X)BitMasks.extract(scalar, 32, 35);
            seek(dst,9) = (X)BitMasks.extract(scalar, 36, 39);
            seek(dst,10) = (X)BitMasks.extract(scalar, 40, 43);
            seek(dst,11) = (X)BitMasks.extract(scalar, 44, 47);
            seek(dst,12) = (X)BitMasks.extract(scalar, 48, 53);
            seek(dst,13) = (X)BitMasks.extract(scalar, 52, 55);
            seek(dst,14) = (X)BitMasks.extract(scalar, 56, 59);
            seek(dst,15) = (X)BitMasks.extract(scalar, 60, 63);
            return dst;
        }

        /// <summary>
        /// Computes the digits corresponding to each 4-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static Span<HexDigit> digits(Perm16L src)
            => digits(src, alloc<HexDigit>(16));
    }
}