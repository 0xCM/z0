//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static nfunc;
    using static constant;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    /// <remarks>In the interest of performance, no checks are performed that verify source character
    /// arguments actually represent digits; unexpected results will occur if this implicit constraint
    /// ins not satisfied</remarks>
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
        /// Extracts an encoded digit
        /// </summary>
        /// <param name="src">The digit source</param>
        /// <param name="index">The base-16 index</param>
        [MethodImpl(Inline)]
        public static ulong digit(ulong src, int index)
            => 0xF & (src >> index*4);

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

        [MethodImpl(Inline)]
        public static void digits(ulong src, out byte d3, out byte d2, out byte d1, out byte d0)
        {
            d3 = (byte)digit(src,3);
            d2 = (byte)digit(src,2);
            d1 = (byte)digit(src,1);
            d0 = (byte)digit(src,0);
        }

        [MethodImpl(Inline)]
        public static void digits(ulong src, Span<byte> dst)
        {
            ref var head = ref MemoryMarshal.GetReference(dst);
            Unsafe.Add(ref head, 7) = (byte)digit(src,3);
            Unsafe.Add(ref head, 6) = (byte)digit(src,2);
            Unsafe.Add(ref head, 5) = (byte)digit(src,1);
            Unsafe.Add(ref head, 4) = (byte)digit(src,0);
            Unsafe.Add(ref head, 3) = (byte)digit(src,3);
            Unsafe.Add(ref head, 2) = (byte)digit(src,2);
            Unsafe.Add(ref head, 1) = (byte)digit(src,1);
            Unsafe.Add(ref head, 0) = (byte)digit(src,0);
        }

    }

}
