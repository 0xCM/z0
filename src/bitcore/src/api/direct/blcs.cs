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
        /// Enables the source operand's rightmost / least significant zero bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public static byte blcs(byte src)
            => (byte)(src | (byte)(src + 1));

        /// <summary>
        /// Enables the source operand's rightmost / least significant zero bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public static ushort blcs(ushort src)
            => (ushort)(src | (ushort)(src + 1));

        /// <summary>
        /// Enables the source operand's rightmost / least significant zero bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public static uint blcs(uint src)
            => src | (src + 1u);

        /// <summary>
        /// Enables the source operand's rightmost / least significant zero bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public static ulong blcs(ulong src)
            => src | (src + 1ul);
    }
}