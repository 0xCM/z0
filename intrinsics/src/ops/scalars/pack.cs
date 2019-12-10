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
    using static ginx;
    using static AsIn;

    partial class ginxs
    {
        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]
        public static byte pack<T>(in ConstBlock64<T> src, int block = 0)
            where T : unmanaged
        {
            var x = ginx.vscalar(n128, const64(in src.BlockRef(block)));
            x = ginx.vsll(x,7);
            return (byte)ginx.vtakemask(x);
        }

        /// <summary>
        /// Pack 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort pack<T>(in ConstBlock128<T> src, int block = 0)
            where T : unmanaged
        {
            var x = ginx.vload(n128, in const64(in src.BlockRef(block)));
            x = ginx.vsll(x,7);
            return ginx.vtakemask(x);
        }

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack<T>(in Block256<T> src, int block = 0)
            where T : unmanaged
                => pack32(in src.BlockRef(block));
        // {
        //     var x = ginx.vload(n256, in const64(in src.BlockRef(block)));
        //     x = ginx.vsll(x,7);
        //     return ginx.vtakemask(x);
        // }

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pack<T>(in ConstBlock256<T> src, int block = 0)
            where T : unmanaged
                => pack32(in src.BlockRef(block));
        // {
        //     var x = ginx.vload(n256, in const64(in src.BlockRef(block)));
        //     x = ginx.vsll(x,7);
        //     return ginx.vtakemask(x);
        // }

        /// <summary>
        /// Packs 64 1-bit values taken from the least significant bit of each source byte from both hi and lo sources
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong pack<T>(in ConstBlock256<T> lo, in ConstBlock256<T> hi, int block = 0)
            where T : unmanaged
        {
            var dst = (ulong)pack(lo,block);
            dst |= ((ulong)pack(hi,block) << 32);
            return dst;
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