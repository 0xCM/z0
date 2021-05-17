//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Root;

    partial class Bits
    {
        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static sbyte bitseg(sbyte src, byte k0, byte k1)
            => (sbyte)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static byte bitseg(byte src, byte k0, byte k1)
            => (byte)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static short bitseg(short src, byte k0, byte k1)
            => (short)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static ushort bitseg(ushort src, byte k0, byte k1)
            => (ushort)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static uint bitseg(uint src, byte k0, byte k1)
            => Bmi1.BitFieldExtract(src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static int bitseg(int src, byte k0, byte k1)
            => (int)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static ulong bitseg(ulong src, byte k0, byte k1)
            => Bmi1.X64.BitFieldExtract(src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static long bitseg(long src, byte k0, byte k1)
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static float bitseg(float src, byte k0, byte k1)
            => BitConverter.Int32BitsToSingle(bitseg(BitConverter.SingleToInt32Bits(src), k0, k1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), BitSeg]
        public static double bitseg(double src, byte k0, byte k1)
            => BitConverter.Int64BitsToDouble(bitseg(BitConverter.DoubleToInt64Bits(src), k0, k1));
    }
}