//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Part;

    partial class Bits
    {
        /// <summary>
        /// Extracts a contiguous range of bits of specified length from a source beginning at a specified index
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static sbyte slice(sbyte src, byte start, byte length)
            => (sbyte)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static byte slice(byte src, byte start, byte length)
            => (byte)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="length">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static short slice(short src, byte start, byte length)
            => (short)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="length">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static ushort slice(ushort src, byte start, byte length)
            => (ushort)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="length">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static uint slice(uint src, byte start, byte length)
            => Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="length">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static int slice(int src, byte start, byte length)
            => (int)Bmi1.BitFieldExtract((uint)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="length">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static ulong slice(ulong src, byte start, byte length)
            => Bmi1.X64.BitFieldExtract(src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="length">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static long slice(long src, byte start, byte length)
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="length">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static float slice(float src, byte start, byte length)
            => slice(Numeric.force<uint>(src), start, length);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit position within the source where extraction should begin</param>
        /// <param name="length">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Slice]
        public static double slice(double src, byte start, byte length)
            => slice(Numeric.force<ulong>(src), start, length);
    }
}