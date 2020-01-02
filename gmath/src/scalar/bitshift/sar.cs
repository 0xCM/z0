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
        public static sbyte sar(sbyte src, int offset)
            =>(sbyte)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static byte sar(byte src, int offset)
            => (byte)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static short sar(short src, int offset)
            => (short)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ushort sar(ushort src, int offset)
            => (ushort)(src >> offset);

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static int sar(int src, int offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static uint sar(uint src, int offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static long sar(long src, int offset)
            => src >> offset;

        /// <summary>
        /// Computes the arithmetic right shift z := src >> offset
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ulong sar(ulong src, int offset)
            => src >> offset;
 
    }
}