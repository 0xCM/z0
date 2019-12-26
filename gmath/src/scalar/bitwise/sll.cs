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
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static sbyte sll(sbyte src, int offset)
            => (sbyte)(src << offset);

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static byte sll(byte src, int offset)
            => (byte)(src << offset);

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static short sll(short src, int offset)
            => (short)(src << offset);

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static ushort sll(ushort src, int offset)
            => (ushort)(src << offset);

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static int sll(int src, int offset)
            => src << offset;

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static uint sll(uint src, int offset)
            => src << offset;

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static long sll(long src, int offset)
            => src << offset;

        /// <summary>
        /// Applies a logical left shift to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift leftwards</param>
        [MethodImpl(Inline)]
        public static ulong sll(ulong src, int offset)
            => src << offset;
   }
}