//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static sbyte sar(sbyte src, int offset)
            =>(sbyte)(src >> offset);

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static byte sar(byte src, int offset)
            => (byte)(src >> offset);

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static short sar(short src, int offset)
            => (short)(src >> offset);

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ushort sar(ushort src, int offset)
            => (ushort)(src >> offset);

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static int sar(int src, int offset)
            => src >> offset;

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static uint sar(uint src, int offset)
            => src >> offset;

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static long sar(long src, int offset)
            => src >> offset;

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ulong sar(ulong src, int offset)
            => src >> offset;
 
        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref sbyte sar(ref sbyte src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref byte sar(ref byte src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref short sar(ref short src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref ushort sar(ref ushort src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref int sar(ref int src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref uint sar(ref uint src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref long sar(ref long src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref ulong sar(ref ulong src, int offset)
        {
            src >>= offset;
            return ref src;
        }
    }
}