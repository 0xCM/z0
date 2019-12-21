//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMask
    {
        [MethodImpl(Inline)]
        public static T between<T>(T src, int i0, int i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(between(uint8(src),i0,i1));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(between(uint16(src),i0,i1));
            else if(typeof(T) == typeof(uint))
                return generic<T>(between(uint32(src),i0,i1));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(between(uint64(src),i0,i1));
            else
                return between_i<T>(src,i0,i1);
        }

        [MethodImpl(Inline)]
        static T between_i<T>(T src, int i0, int i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(between(int8(src),i0,i1));
            else if(typeof(T) == typeof(short))
                return generic<T>(between(int16(src),i0,i1));
            else if(typeof(T) == typeof(int))
                return generic<T>(between(int32(src),i0,i1));
            else if(typeof(T) == typeof(long))
                return generic<T>(between(int64(src),i0,i1));
            else
                return between_f(src,i0,i1);
        }

        [MethodImpl(Inline)]
        static T between_f<T>(T src, int i0, int i1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(between(float32(src),i0,i1));
            else if(typeof(T) == typeof(double))
                return generic<T>(between(float64(src),i0,i1));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static byte between(byte src, int i0, int i1)        
            => (byte)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static sbyte between(sbyte src, int i0, int i1)        
            => (sbyte)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static ushort between(ushort src, int i0, int i1)        
            => (ushort)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static short between(short src, int i0, int i1)        
            => (short)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static uint between(uint src, int i0, int i1)        
            => Bmi1.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static int between(int src, int i0, int i1)        
            => (int)Bmi1.BitFieldExtract((uint)src, (byte)i0, (byte)(i1 - i0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static ulong between(ulong src, int i0, int i1)
            => Bmi1.X64.BitFieldExtract(src, (byte)i0, (byte)(i1 - i0 + 1));            

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static long between(long src, int i0, int i1)        
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, (byte)i0, (byte)(i1 - i0 + 1));            

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static float between(float src, int i0, int i1)        
            => BitConverter.Int32BitsToSingle(between(BitConverter.SingleToInt32Bits(src), i0, i1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="i0">The first bit position</param>
        /// <param name="i1">The last bit position</param>
        [MethodImpl(Inline)]
        public static double between(double src, int i0, int i1)        
            => BitConverter.Int64BitsToDouble(between(BitConverter.DoubleToInt64Bits(src), i0, i1));
    }
}