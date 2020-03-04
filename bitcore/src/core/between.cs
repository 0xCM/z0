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
        [MethodImpl(Inline), Op]
        public static sbyte between(sbyte src, byte k0, byte k1)        
            => (sbyte)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static byte between(byte src, byte k0, byte k1)        
            => (byte)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static short between(short src, byte k0, byte k1)        
            => (short)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static ushort between(ushort src, byte k0, byte k1)        
            => (ushort)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static uint between(uint src, byte k0, byte k1)        
            => Bmi1.BitFieldExtract(src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static int between(int src, byte k0, byte k1)        
            => (int)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static ulong between(ulong src, byte k0, byte k1)
            => Bmi1.X64.BitFieldExtract(src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static long between(long src, byte k0, byte k1)
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, k0, (byte)(k1 - k0 + 1));            

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static float between(float src, byte k0, byte k1)
            => BitConverter.Int32BitsToSingle(between(BitConverter.SingleToInt32Bits(src), k0, k1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline), Op]
        public static double between(double src, byte k0, byte k1)
            => BitConverter.Int64BitsToDouble(between(BitConverter.DoubleToInt64Bits(src), k0, k1));
    }
}