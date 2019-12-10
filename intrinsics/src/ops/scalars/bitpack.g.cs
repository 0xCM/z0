//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    partial class ginxs
    {
        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]
        public static byte bitpack<T>(in ConstBlock64<T> src, int block = 0)
            where T : unmanaged
                => pack8(in src.BlockRef(block));

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static byte bitpack<T>(in Block64<T> src, int block = 0)
            where T : unmanaged
                => pack8(in src.BlockRef(block));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort bitpack<T>(in Block128<T> src, int block = 0)
            where T : unmanaged
                => pack16(in src.BlockRef(block));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort bitpack<T>(in ConstBlock128<T> src, int block = 0)
            where T : unmanaged
                => pack16(in src.BlockRef(block));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static uint bitpack<T>(in Block256<T> src, int block = 0)
            where T : unmanaged
                => pack32(in src.BlockRef(block));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static uint bitpack<T>(in ConstBlock256<T> src, int block = 0)
            where T : unmanaged
                => pack32(in src.BlockRef(block));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte from both hi and lo sources
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong bitpack<T>(in ConstBlock256<T> lo, in ConstBlock256<T> hi, int block = 0)
            where T : unmanaged
        {
            var dst = (ulong)bitpack(lo,block);
            dst |= ((ulong)bitpack(hi,block) << 32);
            return dst;
        }

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8<T>(in T src)
            where T : unmanaged
        {
            var x = ginx.vscalar(n128, const64(src));
            return (byte)ginx.vtakemask(ginx.vsll(x,7));
        }

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static ushort pack16<T>(in T src)
            where T : unmanaged
        {
            var x = ginx.vload(n128, const64(src));
            return ginx.vtakemask(ginx.vsll(x,7));
        }

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static uint pack32<T>(in T src)
            where T : unmanaged
        {
            var x = ginx.vload(n256, const64(src));
            return ginx.vtakemask(ginx.vsll(x,7));
        }
    }
}