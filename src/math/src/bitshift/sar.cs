//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class math
    {
        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), Sra]
        public static sbyte sra(sbyte src, byte offset)
            =>(sbyte)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), Sra]
        public static byte sra(byte src, byte offset)
            => (byte)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), Sra]
        public static short sra(short src, byte offset)
            => (short)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), Sra]
        public static ushort sra(ushort src, byte offset)
            => (ushort)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), Sra]
        public static int sra(int src, byte offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), Sra]
        public static uint sra(uint src, byte offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), Sra]
        public static long sra(long src, byte offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline), Sra]
        public static ulong sra(ulong src, byte offset)
            => src >> offset; 
    }
}