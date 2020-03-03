//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;    

    partial class math
    {
        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline), Op]
        public static byte xorsl(byte a, byte offset)
            => (byte)xorsl((uint)a, offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline), Op]
        public static sbyte xorsl(sbyte a, byte offset)
            => (sbyte)xorsl((int)a, offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline), Op]
        public static ushort xorsl(ushort a, byte offset)
            => (ushort)xorsl((uint)a, offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline), Op]
        public static short xorsl(short a, byte offset)
            => (short)xorsl((int)a, offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline), Op]
        public static int xorsl(int a, byte offset)
            => a^(a << offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline), Op]
        public static uint xorsl(uint a, byte offset)
            => a^(a << offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline), Op]
        public static long xorsl(long a, byte offset)
            => a^(a << offset);

        /// <summary>
        /// Computes a^(a << offset)
        /// </summary>
        /// <param name="a">The source value</param>
        /// <param name="offset">The number of bits to shift the source value leftwards</param>
        [MethodImpl(Inline), Op]
        public static ulong xorsl(ulong a, byte offset)
            => a^(a << offset);
    }
}