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
        public static bit msb(byte src)
            => testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static bit msb(sbyte src)
            => testbit(src,7);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static bit msb(ushort src)
            => testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static bit msb(short src)
            => testbit(src,15);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static bit msb(uint src)
            => testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static bit msb(int src)
            => testbit(src,31);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static bit msb(ulong src)
            => testbit(src,63);

        /// <summary>
        /// Returns the state of the most significant bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static bit msb(long src)
            => testbit(src,63);
    }
}