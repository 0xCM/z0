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
        /// Extracts a contiguous range of bits from the source
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), BitSlice]
        public static sbyte bitslice(sbyte src, byte start, byte length)
            => (sbyte)BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), BitSlice]
        public static byte bitslice(byte src, byte start, byte length)
            => (byte)BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), BitSlice]
        public static short bitslice(short src, byte start, byte length)
            => (short)BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), BitSlice]
        public static ushort bitslice(ushort src, byte start, byte length)
            => (ushort)BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), BitSlice]
        public static int bitslice(int src, byte start, byte length)
            => (int)BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), BitSlice]
        public static uint bitslice(uint src, byte start, byte length)
            => BitFieldExtract(src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// unsigned __int64 _bextr_u64 (unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), BitSlice]
        public static long bitslice(long src, byte start, byte length)
            => (long)BitFieldExtract((ulong)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// unsigned __int64 _bextr_u64 (unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), BitSlice]
        public static ulong bitslice(ulong src, byte start, byte length)
            => BitFieldExtract(src, start, length);
    }
}