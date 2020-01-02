//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {
        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static byte xors(byte a, int offset)
            => (byte)xors((uint)a,offset);

        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static sbyte xors(sbyte a, int offset)
            => (sbyte)xors((byte)a,offset);

        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static ushort xors(ushort a, int offset)
            => (ushort)xors((uint)a,offset);

        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static short xors(short a, int offset)
            => (short)xors((ushort)a,offset);

        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static uint xors(uint a, int offset)
            => a^((a << offset) ^ (a >> offset));

        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static int xors(int a, int offset)
            => a^((a << offset) ^ (a >> offset));

        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static long xors(long src, int offset)
            => src^((src << offset) ^ (src >> offset));

        /// <summary>
        /// Computes a ^ ((a << offset) ^ (a >> offset));
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline)]
        public static ulong xors(ulong src, int offset)
            => src^((src << offset) ^ (src >> offset));
    }
}