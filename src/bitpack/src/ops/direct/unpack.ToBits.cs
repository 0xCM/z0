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
    using static BitMasks;

    partial class BitPack
    {
        /// <summary>
        /// Distributes 8 packed source bits to 8 corresponding target gits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack8(byte src, Span<bit> dst)
            => unpack8(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes 16 packed source bits to 16 corresponding target gits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack16(ushort src, Span<bit> dst)
            => unpack16(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes 16 packed source bits to 32 corresponding target gits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack32(uint src, Span<bit> dst)
            => unpack32(src, ref u8(first(dst)));

        /// <summary>
        /// Distributes 64 packed source bits to 64 corresponding target gits
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack64(ulong src, Span<bit> dst)
            => unpack64(src, ref u8(first(dst)));
    }
}