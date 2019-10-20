//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;    

    partial class Bits
    {                        
        /// <summary>
        /// Intrinsic: unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// Extracts a contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static sbyte segment(sbyte src, int i0, int i1)
            => (sbyte)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// Intrinsic: unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// Extracts a contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static byte segment(byte src, int i0, int i1)
            => (byte)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// Intrinsic: unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// Extracts an index-identified contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static ushort segment(ushort src, int i0, int i1)
            => (ushort)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// Extracts a contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static short segment(short src, int i0, int i1)
            => (short)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts a contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static int segment(int src, int i0, int i1)
            => (int)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// unsigned int _bextr_u32 (unsigned int a, unsigned int start, unsigned int len) BEXTR r32a, reg/m32, r32b
        /// Extracts a contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static uint segment(uint src, int i0, int i1)
            => Bmi1.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// Intrinsic: unsigned __int64 _bextr_u64(unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b
        /// Extracts a contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static long segment(long src, int i0, int i1)
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// Intrinsic: unsigned __int64 _bextr_u64(unsigned __int64 a, unsigned int start, unsigned int len) BEXTR r64a, reg/m64, r64b
        /// Extracts an index-identified contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static ulong segment(ulong src, int i0, int i1)
            => Bmi1.X64.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0));

        /// <summary>
        /// Extracts a contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static float segment(float src, int i0, int i1)
            => BitConverter.Int32BitsToSingle(segment(src.ToBits(), i0, i1));

        /// <summary>
        /// Extracts a contiguous segment of bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The position of the first bit</param>
        /// <param name="i1">The position of the last bit</param>
        [MethodImpl(Inline)]
        public static double segment(double src, int i0, int i1)
            => BitConverter.Int64BitsToDouble(segment(src.ToBits(), i0, i1));

    }

}