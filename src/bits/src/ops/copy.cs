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
        /// Overwrites a target bit segment dst[index..(start + count)] with the corresponding source segment src[index..(start + count)]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source/target start index</param>
        /// <param name="count">The number of bits to copy</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Copy]
        public static byte bitcopy(byte src, byte index, byte count, byte dst)
            => math.or(disable(dst, index, count), math.sll(extract(src, index, count), index));

        /// <summary>
        /// Overwrites a target bit segment dst[index..(start + count)] with the corresponding source segment src[index..(start + count)]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source/target start index</param>
        /// <param name="count">The number of bits to copy</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Copy]
        public static ushort bitcopy(ushort src, byte index, byte count, ushort dst)
            => math.or(disable(dst, index, count), math.sll(extract(src, index, count), index));

        /// <summary>
        /// Overwrites a target bit segment dst[index..(start + count)] with the corresponding source segment src[index..(start + count)]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source/target start index</param>
        /// <param name="count">The number of bits to copy</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Copy]
        public static uint bitcopy(uint src, byte index, byte count, uint dst)
            => math.or(disable(dst, index, count), math.sll(extract(src, index, count), index));

        /// <summary>
        /// Overwrites a target bit segment dst[index..(start + count)] with the corresponding source segment src[index..(start + count)]
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="index">The source/target start index</param>
        /// <param name="count">The number of bits to copy</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Copy]
        public static ulong bitcopy(ulong src, byte index, byte count, ulong dst)
            => math.or(disable(dst, index, count), math.sll(extract(src, index, count), index));
     }
}