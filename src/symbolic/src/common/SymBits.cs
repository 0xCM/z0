//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Seed;
    using static Control;

    public class SymBits
    {
        [MethodImpl(Inline)]
        internal static unsafe Vector128<byte> vbroadcast(W128 w, byte src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline)]
        internal static unsafe Vector128<ushort> vbroadcast(W128 w, ushort src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline)]
        internal static unsafe Vector256<byte> vbroadcast(W256 w, byte src)
            => BroadcastScalarToVector256(&src);

        [MethodImpl(Inline)]
        internal static unsafe Vector256<ushort> vbroadcast(W256 w, ushort src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static sbyte extract(sbyte src, byte k0, byte k1)        
            => (sbyte)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static byte extract(byte src, byte k0, byte k1)        
            => (byte)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static short extract(short src, byte k0, byte k1)        
            => (short)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ushort extract(ushort src, byte k0, byte k1)        
            => (ushort)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static uint extract(uint src, byte k0, byte k1)        
            => Bmi1.BitFieldExtract(src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static int extract(int src, byte k0, byte k1)        
            => (int)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ulong extract(ulong src, byte k0, byte k1)
            => Bmi1.X64.BitFieldExtract(src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static long extract(long src, byte k0, byte k1)
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, k0, (byte)(k1 - k0 + 1));            

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static float extract(float src, byte k0, byte k1)
            => BitConverter.Int32BitsToSingle(extract(BitConverter.SingleToInt32Bits(src), k0, k1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static double extract(double src, byte k0, byte k1)
            => BitConverter.Int64BitsToDouble(extract(BitConverter.DoubleToInt64Bits(src), k0, k1));

        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vload(W128 w, in byte src)
            => LoadDquVector128((byte*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vload(W256 w, in byte src)
            => LoadDquVector256((byte*)src);            

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// Projects 16 unsigned 8-bit integers onto 16 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vmove8x16(in byte src)
            => ConvertToVector256Int16(constptr(src)).AsUInt16();
    }
}