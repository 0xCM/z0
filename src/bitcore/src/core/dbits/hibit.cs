//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Bits
    {
        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitState msb(byte src)
            => testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitState msb(sbyte src)
            => testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitState msb(ushort src)
            => testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitState msb(short src)
            => testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitState msb(uint src)
            => testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitState msb(int src)
            => testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitState msb(ulong src)
            => testbit(src,63);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static BitState msb(long src)
            => As.testbit(src,63);
    }
}