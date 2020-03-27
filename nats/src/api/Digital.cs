//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Components;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    /// <remarks>
    /// In the interest of performance, no checks are performed that verify source character
    /// arguments actually represent digits; unexpected results will occur otherwise
    /// </remarks>
    public static class Digital
    {        
        /// <summary>
        /// Converts a character in the inclusive range [0,9] to the corresponding number in the same range
        /// </summary>
        /// <param name="c">The digit character</param>
        [MethodImpl(Inline)]
        public static ulong digit(char c)
            => (ulong)c - (ulong)'0'; 

        [MethodImpl(Inline)]
        public static char character(ulong digit)
            => (char)(digit + (ulong)'0');

        [MethodImpl(Inline)]
        public static char character<N>()
            where N : unmanaged, ITypeNat
                => character(NatMath2.natval<N>());

        [MethodImpl(Inline)]
        public static void chars(ushort src, out char c1, out char c0)
        {
            c1 = character(digit(src,1));
            c0 = character(digit(src,1));
        }

        [MethodImpl(Inline)]
        public static void chars(uint src, out char c3, out char c2, out char c1, out char c0)
        {
            c3 = character(digit(src,3));
            c2 = character(digit(src,2));
            c1 = character(digit(src,1));
            c0 = character(digit(src,0));
        }

        [MethodImpl(Inline)]
        public static void chars(ulong src, out char c7, out char c6, out char c5, out char c4, out char c3, out char c2, out char c1, out char c0)
        {
            c7 = character(digit(src,7));
            c6 = character(digit(src,6));
            c5 = character(digit(src,5));
            c4 = character(digit(src,4));
            c3 = character(digit(src,3));
            c2 = character(digit(src,2));
            c1 = character(digit(src,1));
            c0 = character(digit(src,0));
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> chars(uint src)
        {
            Span<char> dst = new char[4];
            ref var target = ref MemoryMarshal.GetReference(dst);
            chars(src, out add(ref target, 3), out add(ref target, 2), out add(ref target, 1), out add(ref target, 0));
            return dst;
        }
        
        /// <summary>
        /// Encodes two decimal digits d := 0x[c1][c0] for characters c2, c1 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c1">The source for digit 1, the most significant digit</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline)]
        public static ulong digits(char c1, char c0)
        {
            const int width = 4;
            var packed = 0ul;
            packed |= (digit(c0) << 0*width);
            packed |= (digit(c1) << 1*width);
            return packed;
        }

        /// <summary>
        /// Encodes three decimal digits d := 0x[c2][c1][c0] for characters c2, c1, c0 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c2">The source for digit 2, the most significant digit</param>
        /// <param name="c1">The source for digit 1</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline)]
        public static ulong digits(char c2, char c1, char c0)
        {
            const int width = 4;
            var packed = 0ul;
            packed |= (digit(c0) << 0*width);
            packed |= (digit(c1) << 1*width);
            packed |= (digit(c2) << 2*width);
            return packed;
        }

        /// <summary>
        /// Encodes four decimal digits d := 0x[c3][c2][c1][c0] for characters c3, c2, c1, c0 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c3">The source for digit 3, the most significant digit</param>
        /// <param name="c2">The source for digit 2</param>
        /// <param name="c1">The source for digit 1</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline)]
        public static ulong digits(char c3, char c2, char c1, char c0)
        {
            const int width = 4;
            var packed = 0ul;
            packed |= (digit(c0) << 0*width);
            packed |= (digit(c1) << 1*width);
            packed |= (digit(c2) << 2*width);
            packed |= (digit(c3) << 3*width);
            return packed;
        }

        /// <summary>
        /// Encodes five decimal digits d := 0x[c4][c3][c2][c1][c0] for characters c4, c3, c2, c1, c0 in the inclusive range [0,9]
        /// </summary>
        /// <param name="c4">The source for digit 4, the most significant digit</param>
        /// <param name="c3">The source for digit 3</param>
        /// <param name="c2">The source for digit 2</param>
        /// <param name="c1">The source for digit 1</param>
        /// <param name="c0">The source for digit 0, the least significant digit</param>
        [MethodImpl(Inline)]
        public static ulong digits(char c4, char c3, char c2, char c1, char c0)
        {
            const int width = 4;
            var packed = 0ul;
            packed |= (digit(c0) << 0*width);
            packed |= (digit(c1) << 1*width);
            packed |= (digit(c2) << 2*width);
            packed |= (digit(c3) << 3*width);
            packed |= (digit(c4) << 4*width);
            return packed;
        }

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
        [MethodImpl(Inline)]
        public static ulong digits(char c7, char c6, char c5, char c4, char c3, char c2, char c1, char c0)
        {
            const int width = 4;
            var packed = 0ul;
            packed |= (digit(c0) << 0*width);
            packed |= (digit(c1) << 1*width);
            packed |= (digit(c2) << 2*width);
            packed |= (digit(c3) << 3*width);
            packed |= (digit(c4) << 4*width);
            packed |= (digit(c5) << 5*width);
            packed |= (digit(c6) << 6*width);
            packed |= (digit(c7) << 7*width);
            return packed;
        }

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 7] that identifies the digit to extract</param>
        [MethodImpl(Inline)]
        public static ulong digit(ulong src, int index)
            => 0xF & (src >> index*4);

        /// <summary>
        /// Extracts two encoded digits
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="d1">The most significant digit</param>
        /// <param name="d0">The least significant digit</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, out byte d1, out byte d0)
        {
            d1 = (byte)digit(src,1);
            d0 = (byte)digit(src,0);
        }

        [MethodImpl(Inline)]
        public static void digits(ulong src, out byte d2, out byte d1, out byte d0)
        {
            d2 = (byte)digit(src,2);
            d1 = (byte)digit(src,1);
            d0 = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the four lo digits
        /// </summary>
        /// <param name="src">The encoded digit source</param>
        /// <param name="d3">The target for the fourth and most-significant digit</param>
        /// <param name="d2">The target for the third digit</param>
        /// <param name="d1">The target for the second digit</param>
        /// <param name="d0">The target for the first and least-significant digit</param>
        [MethodImpl(Inline)]
        public static void lo(ulong src, out byte d3, out byte d2, out byte d1, out byte d0)
        {
            d3 = (byte)digit(src,3);
            d2 = (byte)digit(src,2);
            d1 = (byte)digit(src,1);
            d0 = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the four hi digits
        /// </summary>
        /// <param name="src">The encoded digit source</param>
        /// <param name="d7">The target for the eighth and most-significant digit</param>
        /// <param name="d6"></param>
        /// <param name="d5"></param>
        /// <param name="d4"></param>
        [MethodImpl(Inline)]
        public static void hi(ulong src, out byte d7, out byte d6, out byte d5, out byte d4)
        {
            d7 = (byte)digit(src,7);
            d6 = (byte)digit(src,6);
            d5 = (byte)digit(src,5);
            d4 = (byte)digit(src,4);
        }

        /// <summary>
        /// Extracts the first digit from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="count">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, N1 count, ref byte dst)
        {
            add(ref dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first two digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="count">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, N2 count, ref byte dst)
        {
            add(ref dst, 1) = (byte)digit(src,1);
            add(ref dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first three digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="count">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, N3 count, ref byte dst)
        {
            add(ref dst, 2) = (byte)digit(src,2);
            add(ref dst, 1) = (byte)digit(src,1);
            add(ref dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first four digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="count">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, N4 count, ref byte dst)
        {
            add(ref dst, 3) = (byte)digit(src,3);
            add(ref dst, 2) = (byte)digit(src,2);
            add(ref dst, 1) = (byte)digit(src,1);
            add(ref dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first five digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="count">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, N5 count, ref byte dst)
        {
            add(ref dst, 4) = (byte)digit(src,4);
            add(ref dst, 3) = (byte)digit(src,3);
            add(ref dst, 2) = (byte)digit(src,2);
            add(ref dst, 1) = (byte)digit(src,1);
            add(ref dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first six digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="count">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, N6 count, ref byte dst)
        {
            add(ref dst, 5) = (byte)digit(src,5);
            add(ref dst, 4) = (byte)digit(src,4);
            add(ref dst, 3) = (byte)digit(src,3);
            add(ref dst, 2) = (byte)digit(src,2);
            add(ref dst, 1) = (byte)digit(src,1);
            add(ref dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts the first seven digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="count">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, N7 count, ref byte dst)
        {
            add(ref dst, 6) = (byte)digit(src,6);
            add(ref dst, 5) = (byte)digit(src,5);
            add(ref dst, 4) = (byte)digit(src,4);
            add(ref dst, 3) = (byte)digit(src,3);
            add(ref dst, 2) = (byte)digit(src,2);
            add(ref dst, 1) = (byte)digit(src,1);
            add(ref dst, 0) = (byte)digit(src,0);
        }

        /// <summary>
        /// Extracts all eight digits from the source
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="count">The digit count selector</param>
        /// <param name="dst">The digit receiver</param>
        [MethodImpl(Inline)]
        public static void digits(ulong src, N8 count, ref byte dst)
        {
            add(ref dst, 6) = (byte)digit(src,6);
            add(ref dst, 5) = (byte)digit(src,5);
            add(ref dst, 4) = (byte)digit(src,4);
            add(ref dst, 3) = (byte)digit(src,3);
            add(ref dst, 2) = (byte)digit(src,2);
            add(ref dst, 1) = (byte)digit(src,1);
            add(ref dst, 0) = (byte)digit(src,0);
        }

        [MethodImpl(Inline)]
        static ref T add<T>(ref T src, int count)
            => ref Unsafe.Add(ref src, count);

    }

}
