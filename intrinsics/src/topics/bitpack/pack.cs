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

    partial class BitPack
    {
        public static Span<T> pack<S,T>(ReadOnlySpan<S> src, T t = default)
            where S : unmanaged
            where T : unmanaged
        {            
            var inbits = src.Length * bitsize<S>();
            var outcells = inbits / bitsize<S>() + (inbits % bitsize<S>() == 0 ? 0 : 1);
            Span<T> dstcells = new T[outcells];            
            return default;            
        }

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]
        public static byte pack<T>(in ConstBlock64<T> src, int block = 0)
            where T : unmanaged
                => pack8(in src.BlockRef(block));

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static byte pack<T>(in Block64<T> src, int block = 0)
            where T : unmanaged
                => pack8(in src.BlockRef(block));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort pack<T>(in Block128<T> src, int block = 0)
            where T : unmanaged
                => pack16(in src.BlockRef(block));

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort pack<T>(in ConstBlock128<T> src, int block = 0)
            where T : unmanaged
                => pack16(in src.BlockRef(block));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack<T>(in Block256<T> src, int block = 0)
            where T : unmanaged
                => pack32(in src.BlockRef(block));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte from both hi and lo sources
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack<T>(in Block512<T> src, int block = 0)
            where T : unmanaged
                => pack64(in src.BlockRef(block));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack<T>(in ConstBlock256<T> src, int block = 0)
            where T : unmanaged
                => pack32(in src.BlockRef(block));

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte from both hi and lo sources
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack<T>(in ConstBlock512<T> src, int block = 0)
            where T : unmanaged
                => pack64(in src.BlockRef(block));

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8(ulong src)
            => (byte)ginx.vtakemask(ginx.vsll(ginx.vscalar(n128, const64(src)),7));

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8<T>(in T src)
            where T : unmanaged
                => (byte)ginx.vtakemask(ginx.vsll(ginx.vscalar(n128, const64(src)),7));

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static ushort pack16<T>(in T src)
            where T : unmanaged
                => ginx.vtakemask(ginx.vsll(ginx.vload(n128, const64(src)),7));

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static uint pack32<T>(in T src)
            where T : unmanaged
                => ginx.vtakemask(ginx.vsll(ginx.vload(n256, const64(src)),7));

        [MethodImpl(Inline)]
        static ulong pack64<T>(in T src, int block = 0)
            where T : unmanaged
        {
            var dst = 0ul;
            dst = (ulong)pack32(in src);
            dst |=(ulong)pack32(in skip(in src, 32)) << 32;
            return dst;
        }



    }

}