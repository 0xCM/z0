//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    using B = BinaryDigit;
    using D = DecimalDigit;
    using X = HexDigit;

    using BS = BinarySym;
    using HSL = HexSymLo;
    using HSU = HexSymUp;

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
        public static Span<D> digits(ReadOnlySpan<char> src, Span<D> dst)
        {
            var len = src.Length;
            for(var i=0u; i< len; i++)
                seek(dst,i) = Digital.digit(base10, skip(src,i));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSL> src, Span<X> dst)
        {
            var len = src.Length;
            for(var i=0u; i<len; i++)
                seek(dst,i) = Digital.digit(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HSU> src, Span<X> dst)
        {
            var len = src.Length;
            for(var i=0u; i<len; i++)
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
        /// Computes the digits corresponding to each 2-bit segment of the permutation spec
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
        /// Computes the digits corresponding to each 2-bit segment of the permutation spec
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
        /// Computes the digits corresponding to each 2-bit segment of the permutation spec
        /// </summary>
        /// <param name="src">The perm spec</param>
        public static NatSpan<N4,byte> digits(Perm4L src)
            => digits(src,NatSpan.alloc<N4,byte>());

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<BS> src, Span<B> dst)
        {
            var len = src.Length;
            for(var i=0u; i<len; i++)
                seek(dst,i) = Digital.digit(skip(src,i));
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
        public static Span<OctalDigit> digits(Perm8L src)
            => digits(src, z.alloc<OctalDigit>(8));

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
        public static Span<X> digits(Perm16L src)
            => digits(src, z.alloc<X>(16));
    }
}