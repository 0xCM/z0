//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    
    partial class math
    {
        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static sbyte sar(sbyte src, byte offset)
            =>(sbyte)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static byte sar(byte src, byte offset)
            => (byte)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static short sar(short src, byte offset)
            => (short)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ushort sar(ushort src, byte offset)
            => (ushort)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static int sar(int src, byte offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static uint sar(uint src, byte offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static long sar(long src, byte offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ulong sar(ulong src, byte offset)
            => src >> offset;
 
    }
}