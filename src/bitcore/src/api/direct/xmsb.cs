//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Bits
    {
        /// <summary>
        /// Extracts the most significant enabled bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), XMsb]
        public static byte xmsb(byte src)
            => Pow2.pow8u(hipos(src));

        /// <summary>
        /// Extracts the most significant enabled bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), XMsb]
        public static ushort xmsb(ushort src)
            => Pow2.pow16u(hipos(src));

        /// <summary>
        /// Extracts the most significant enabled bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), XMsb]
        public static uint xmsb(uint src)
            => Pow2.pow32u(hipos(src));

        /// <summary>
        /// Extracts the most significant enabled bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), XMsb]
        public static ulong xmsb(ulong src)
            => Pow2.pow(hipos(src));
    }
}