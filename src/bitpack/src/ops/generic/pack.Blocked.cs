//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class BitPack
    {
        /// <summary>
        /// Packs 4 1-bit values taken from the least significant bit of each source byte of an index-identified block
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mod">The bit selection modulus</param>
        /// <param name="block">The index of the block to pack</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static byte pack<T>(in SpanBlock32<T> src, N8 mod, int block = 0)
            where T : unmanaged
                => (byte)Bits.gather(uint32(src.BlockRef(block)), MaskLiterals.Lsb32x8x1);

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte of an index-identified block
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mod">The bit selection modulus</param>
        /// <param name="block">The index of the block to pack</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static byte pack<T>(in SpanBlock64<T> src, N8 mod, int block = 0)
            where T : unmanaged
                => pack8(convert<T,ulong>(src.BlockRef(block)));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort pack<T>(in SpanBlock128<T> src, N8 mod, int block = 0)
            where T : unmanaged
                => pack(src.BlockRef(block), n16, mod);

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint pack<T>(in SpanBlock256<T> src, N8 mod, int block = 0)
            where T : unmanaged
                => pack(src.BlockRef(block), n32, mod);

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong pack<T>(in SpanBlock512<T> src, N8 mod, int block = 0)
            where T : unmanaged
                => pack(src.BlockRef(block), n64, mod);

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8(ulong src)
            => (byte)Bits.gather(src, MaskLiterals.Lsb64x8x1);
    }
}