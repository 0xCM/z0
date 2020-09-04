//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Sized
    {
        [MethodImpl(Inline)]
        internal static uint2 wrap(W2 w, int src)
            => new uint2((byte)src,false);

        /// <summary>
        /// Creates a 2-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, bool src)
            => new uint2(z.bitstate(src));

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, byte src)
            => new uint2(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, sbyte src)
            => new uint2(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, ushort src)
            => new uint2(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, short src)
            => new uint2(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, int src)
            => new uint2(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, uint src)
            => new uint2(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, long src)
            => new uint2(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, ulong src)
            => new uint2((byte)((byte)src & uint2.MaxVal));

        /// <summary>
        /// Creates a 2-bit unsigned integer from a 2-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        [MethodImpl(Inline), Op]
        public static uint2 create(W2 w, bit x0, bit x1 = default)
             => new uint2(((uint)x0 << 0) | ((uint)x1 << 1), true);
    }
}