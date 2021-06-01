//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
    using static Root;

    partial class Bits
    {
        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Ntz]
        public static sbyte ntz(sbyte src)
           => src == 0 ? (sbyte)8 : (sbyte)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Ntz]
        public static byte ntz(byte src)
           => src == 0 ? (byte)8 : (byte)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Ntz]
        public static short ntz(short src)
           => src == 0 ? (short)16 : (short)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Ntz]
        public static ushort ntz(ushort src)
            => src == 0 ? (ushort)16 : (ushort)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
         [MethodImpl(Inline), Ntz]
         public static int ntz(int src)
            => (int)TrailingZeroCount((uint)src);

        /// <summary>
        /// int _mm_tzcnt_32 (unsigned int a) TZCNT reg, reg/m32
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Ntz]
        public static uint ntz(uint src)
            => TrailingZeroCount(src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Ntz]
        public static long ntz(long src)
            => (long)TrailingZeroCount((ulong)src);

        /// <summary>
        /// __int64 _mm_tzcnt_64 (unsigned __int64 a) TZCNT reg, reg/m64
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Ntz]
        public static ulong ntz(ulong src)
            => TrailingZeroCount(src);
    }
}