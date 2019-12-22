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
    using static AsIn;

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
        /// Packs 4 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static byte pack<T>(in ConstBlock32<T> src)
            where T : unmanaged
                => (byte) dinx.gather(uint32(in src.Head), BitMasks.Lsb32x8x1);

        /// <summary>
        /// Packs 4 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline)]
        public static byte pack<T>(in Block32<T> src)
            where T : unmanaged
                => (byte) dinx.gather(uint32(in src.Head), BitMasks.Lsb32x8x1);

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]
        public static byte pack<T>(in ConstBlock64<T> src, int block = 0)
            where T : unmanaged
                => pack8(convert<T,ulong>(src.BlockRef(block)));

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        public static byte pack<T>(in Block64<T> src, int block = 0)
            where T : unmanaged
                => pack8(convert<T,ulong>(src.BlockRef(block)));

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
            => (byte)dinx.gather(src, BitMasks.Lsb64x8x1);


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

        /// <summary>
        /// Packs 128 isolated bits into a 128 natural block of bits
        /// </summary>
        /// <param name="src">The source bits to condense</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> pack(NatSpan<N128,bit> src)
            => pack128(n1, n32, in head(src.As<uint>()));

        [MethodImpl(Inline)]
        public static Vector128<uint> pack(N1 width, NatSpan<N128,uint> src)
            => pack128(width, n32, in head(src));

        
        /// <summary>
        /// Packs 128 32-bit values into 128 1-bit values captured by a 128-bit vector, adapted
        /// from https://github.com/lemire/FastPFOR 
        /// </summary>
        /// <param name="src">The unpacked data</param>
        [MethodImpl(Inline)]
        static Vector128<uint> pack128(ReadOnlySpan<uint> unpacked)
        {   
            const byte step = 4;
            
            var w = n128;
            var current = 0;                        

            ref readonly var src = ref head(unpacked);

            var xmm1 = ginx.vload(w, in src);            
            var xmm0 = xmm1; 
            xmm1 = ginx.vload(w, in skip(in src, current += step));

            byte offset = 0;
            while(offset++ < 32)
            {
                xmm0 = dinx.vor(xmm0, dinx.vsll(xmm1, offset));
                xmm1 = ginx.vload(w, in skip(in src, current += step));
            }
            return xmm0;

        }

        [MethodImpl(Inline)]
        static void pack1(ref Vector128<uint> xmm0, ref Vector128<uint> xmm1, in uint src, byte step, int offset)
        {
            xmm0 = dinx.vor(xmm0, dinx.vsll(xmm1, step));
            xmm1 = ginx.vload(n128, in skip(in src, offset));
        }

        /// <summary>
        /// Packs 128 32-bit values into 128 1-bit values captured by a 128-bit vector, adapted
        /// from https://github.com/lemire/FastPFOR 
        /// </summary>
        /// <param name="width">The target compression width</param>
        /// <param name="n">The source element width</param>
        /// <param name="src">A reference to the source values</param>
        [MethodImpl(Inline)]
        static Vector128<uint> pack128(N1 width, N32 n, in uint src)
        {
            const int step = 4;
            var nv = n128;
            var current = 0;
                        
            var xmm1 = ginx.vload(nv, in src);            
            var xmm0 = xmm1;            
            xmm1 = ginx.vload(nv, in skip(in src, current += step));

            pack1(ref xmm0, ref xmm1, in src, 1, current += step);
            pack1(ref xmm0, ref xmm1, in src, 2, current += step);
            pack1(ref xmm0, ref xmm1, in src, 3, current += step);
            pack1(ref xmm0, ref xmm1, in src, 4, current += step);
            pack1(ref xmm0, ref xmm1, in src, 5, current += step);
            pack1(ref xmm0, ref xmm1, in src, 6, current += step);
            pack1(ref xmm0, ref xmm1, in src, 7, current += step);
            pack1(ref xmm0, ref xmm1, in src, 8, current += step);
            pack1(ref xmm0, ref xmm1, in src, 9, current += step);
            pack1(ref xmm0, ref xmm1, in src, 10, current += step);
            pack1(ref xmm0, ref xmm1, in src, 11, current += step);
            pack1(ref xmm0, ref xmm1, in src, 12, current += step);
            pack1(ref xmm0, ref xmm1, in src, 13, current += step);
            pack1(ref xmm0, ref xmm1, in src, 14, current += step);
            pack1(ref xmm0, ref xmm1, in src, 15, current += step);
            pack1(ref xmm0, ref xmm1, in src, 16, current += step);
            pack1(ref xmm0, ref xmm1, in src, 17, current += step);
            pack1(ref xmm0, ref xmm1, in src, 18, current += step);
            pack1(ref xmm0, ref xmm1, in src, 19, current += step);
            pack1(ref xmm0, ref xmm1, in src, 20, current += step);
            pack1(ref xmm0, ref xmm1, in src, 21, current += step);
            pack1(ref xmm0, ref xmm1, in src, 22, current += step);
            pack1(ref xmm0, ref xmm1, in src, 23, current += step);
            pack1(ref xmm0, ref xmm1, in src, 24, current += step);
            pack1(ref xmm0, ref xmm1, in src, 25, current += step);
            pack1(ref xmm0, ref xmm1, in src, 26, current += step);
            pack1(ref xmm0, ref xmm1, in src, 27, current += step);
            pack1(ref xmm0, ref xmm1, in src, 28, current += step);
            pack1(ref xmm0, ref xmm1, in src, 29, current += step);
            pack1(ref xmm0, ref xmm1, in src, 30, current += step);
            pack1(ref xmm0, ref xmm1, in src, 31, current += step);
            return xmm0;
        }

    }

}