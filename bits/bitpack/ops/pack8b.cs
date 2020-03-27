//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static As;    
    using static CastNumeric;

    partial class BitPack
    {
        /// <summary>
        /// Packs 4 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static byte pack8<T>(in Block32<T> src, int block = 0)
            where T : unmanaged
                => (byte) Bits.gather(uint32(src.BlockRef(block)), BitMasks.Lsb32x8x1);

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static byte pack8<T>(in Block64<T> src, int block = 0)
            where T : unmanaged
                => pack8(convert<T,ulong>(src.BlockRef(block)));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ushort pack8<T>(in Block128<T> src, int block = 0)
            where T : unmanaged
                => maskpack16(in src.BlockRef(block));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static uint pack8<T>(in Block256<T> src, int block = 0)
            where T : unmanaged
                => maskpack32(in src.BlockRef(block));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ulong pack8<T>(in Block512<T> src, int block = 0)
            where T : unmanaged
                => maskpack64(in src.BlockRef(block));
    }
}