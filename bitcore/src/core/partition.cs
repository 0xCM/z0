//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
 
    using static zfunc;
    using static As;
    
    partial class Bits
    {
        // ~ Nx1
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Partitions the first 4 bits of a 32-bit source into 4 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part4x1(uint src, ref byte dst)
        {
            const uint M = 1;

            seek(ref dst, 0) = (byte)(src >> 0 & M);
            seek(ref dst, 1) = (byte)(src >> 1 & M);
            seek(ref dst, 2) = (byte)(src >> 2 & M);
            seek(ref dst, 3) = (byte)(src >> 3 & M);
        }

        /// <summary>
        /// Partitions the first 5 bits of a 32-bit source into 5 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part5x1(uint src, ref byte dst)
        {
            const uint M = 1;

            seek(ref dst, 0) = (byte)(src >> 0 & M);
            seek(ref dst, 1) = (byte)(src >> 1 & M);
            seek(ref dst, 2) = (byte)(src >> 2 & M);
            seek(ref dst, 3) = (byte)(src >> 3 & M);
            seek(ref dst, 4) = (byte)(src >> 4 & M);
        }

        /// <summary>
        /// Partitions the first 6 bits of a 32-bit source into 6 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part6x1(uint src, ref byte dst)
        {
            const uint M = 1;

            seek(ref dst, 0) = (byte)(src >> 0 & M);
            seek(ref dst, 1) = (byte)(src >> 1 & M);
            seek(ref dst, 2) = (byte)(src >> 2 & M);
            seek(ref dst, 3) = (byte)(src >> 3 & M);
            seek(ref dst, 4) = (byte)(src >> 4 & M);
            seek(ref dst, 5) = (byte)(src >> 5 & M);
        }

        /// <summary>
        /// Partitions the first 7 bits of a 32-bit source into 7 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part7x1(uint src, ref byte dst)
        {
            const uint M = 1;

            seek(ref dst, 0) = (byte)(src >> 0 & M);
            seek(ref dst, 1) = (byte)(src >> 1 & M);
            seek(ref dst, 2) = (byte)(src >> 2 & M);
            seek(ref dst, 3) = (byte)(src >> 3 & M);
            seek(ref dst, 4) = (byte)(src >> 4 & M);
            seek(ref dst, 5) = (byte)(src >> 5 & M);
            seek(ref dst, 6) = (byte)(src >> 6 & M);
        }

        /// <summary>
        /// Partitions the first 8 bits of a 32-bit source into 8 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part8x1(uint src, ref byte dst)
        {
            part4x1(src, ref dst);
            part4x1(src >> 4, ref seek(ref dst, 4));
        }

        /// <summary>
        /// Partitions the first 9 bits of a 32-bit source into 9 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part9x1(uint src, ref byte dst)
        {
            const uint M = 1;
            part8x1(src, ref dst);
            seek(ref dst, 8) = (byte)(src >> 8 & M);
        }

        /// <summary>
        /// Partitions the first 10 bits of a 32-bit source into 10 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part10x1(uint src, ref byte dst)
        {
            const uint M = 1;

            part9x1(src, ref dst);
            seek(ref dst, 9) = (byte)(src >> 9 & M);
        }

        [MethodImpl(Inline)]
        public static void part10x1(uint src, Span<byte> dst)
            => part10x1(src, ref head(dst));
        
        /// <summary>
        /// Partitions a 64-bit source into 64 8-bit targets of effective width 1
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part64x1(ulong src, Span<byte> dst)
        {
            ref var target = ref head64(dst);
            seek(ref target, 0) = lsb8x1(src);
            seek(ref target, 1) = lsb8x1(src >> 8);
            seek(ref target, 2) = lsb8x1(src >> 16);
            seek(ref target, 3) = lsb8x1(src >> 24);
            seek(ref target, 4) = lsb8x1(src >> 32);
            seek(ref target, 5) = lsb8x1(src >> 40);
            seek(ref target, 6) = lsb8x1(src >> 48);
            seek(ref target, 7) = lsb8x1(src >> 56);
        }
 
        /// <summary>
        /// Partitions a 64-bit source value into 64 individual bit values
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part64x1(ulong src, Span<bit> dst)
        {
            // each bit has a 32-bit physical width so 2 bit values = 64 bits of storage
            // thus, the target covers 32 64-bit segments where each segment covers 2 bit values            
            ref var target = ref head(dst.As<bit,ulong>());
            for(int i=0; i<32; i++)
                seek(ref target, i) = lsb32x1(src >> i);
        }

        /// <summary>
        /// Partitions the first 8 bits of a 32-bit source into 4 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part8x2(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x2;

            seek(ref dst, 0) = (byte)(src >> 0 & M);
            seek(ref dst, 1) = (byte)(src >> 2 & M);
            seek(ref dst, 2) = (byte)(src >> 4 & M);
            seek(ref dst, 3) = (byte)(src >> 6 & M);
        }

        // ~ Nx2
        // ~ ------------------------------------------------------------------
 
        /// <summary>
        /// Partitions the source into 4 target segments of physical widht 8 and effective width 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part8x2(byte src, ref byte dst)
            => part8x2((uint)src, ref dst);

        /// <summary>
        /// Partitions a 16-bit source into 8 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part16x2(ushort src, ref byte dst)
        {
            part8x2((byte)src, ref dst);
            part8x2((byte)(src >> 8), ref seek(ref dst, 4));
        }

        [MethodImpl(Inline)]
        public static void part16x2(ushort src, Block64<byte> dst)
            => part16x2(src, ref dst.Head);

        /// <summary>
        /// Partitions a 32-bit source into 16 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x2(uint src, ref byte dst)
        {
            part16x2((ushort)src, ref dst);
            part16x2((ushort)(src >> 16), ref seek(ref dst, 8));
        }        

        [MethodImpl(Inline)]
        public static void part32x2(ushort src, Block128<byte> dst)
            => part16x2(src, ref dst.Head);

        // ~ Nx3
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Partitions the first 6 bits of a 32-bit source value into 2 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part6x3(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x3;

            seek(ref dst, 0) = (byte)(src >> 0 & M);
            seek(ref dst, 1) = (byte)(src >> 3 & M);
        }

        [MethodImpl(Inline)]
        public static void part6x3(uint src, Span<byte> dst)
            => part6x3(src, ref head(dst));

        /// <summary>
        /// Partitions the first 9 bits of a 32-bit source value into 3 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part9x3(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x3;

            part6x3(src, ref dst);
            seek(ref dst, 2) = (byte)(src >> 6 & M);
        }

        [MethodImpl(Inline)]
        public static void part9x3(uint src, Span<byte> dst)
            => part9x3(src, ref head(dst));

        /// <summary>
        /// Partitions the first 12 bits of a 32-bit source into 4 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part12x3(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x3;

            part9x3(src, ref dst);
            seek(ref dst, 3) = (byte)(src >> 9 & M);
        }

        /// <summary>
        /// Partitions the first 15 bits of a 16-bit source into 6 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part15x3(ushort src, in NatSpan<N5,byte> dst)
        {
            const uint M = BitMasks.Lsb32x8x3;

            dst.Cell<uint>(0) = Bits.scatter(src, BitMasks.Lsb32x8x3); 
            dst.Cell<byte>(4) = (byte)Bits.scatter((byte)(src >> 12), BitMasks.Lsb8x8x3);
        }

        /// <summary>
        /// Partitions the first 24 bits of a 32-bit source value into 9 8-bit target segments
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part24x3(uint src, in NatSpan<N8,byte> dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;

            dst.Cell<ulong>(0) = Bits.scatter(src, M); 
        }

        /// <summary>
        /// Partitions the first 27 bits of a 32-bit source value into 9 8-bit target segments
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part27x3(uint src, in NatSpan<N9,byte> dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;

            dst.Cell<ulong>(0) = Bits.scatter(src, M); 
            dst.Cell<ushort>(4) = (byte)Bits.scatter(src >> 24, M); 
        }
 
        /// <summary>
        /// Partitions the first 30 bits of a 32-bit source value into 10 8-bitt target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]
        public static void part30x3(uint src, in NatSpan<N10,byte> dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;

            dst.Cell<ulong>(0) = Bits.scatter(src, M); 
            dst.Cell<ushort>(4) = (ushort)Bits.scatter(src >> 24, M); 
        }

        /// <summary>
        /// Partitions the first 63 bits of a 64 bit source value into 21 8-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]
        public static void part63x3(ulong src, in NatSpan<N21,byte> dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;
            
            var x = BitMask.lo(n63) & src;
            dst.Cell<ulong>(0) = Bits.scatter(x, M); 
            dst.Cell<ulong>(1) = Bits.scatter(x >> 24, M); 
            dst.Cell<ulong>(2) = Bits.scatter(x >> 48, M); 
        }

        // ~ Nx4
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Partitions an 8-bit source value into 2 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part8x4(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x4;

            seek(ref dst, 0) = (byte)((src >> 0) & M);
            seek(ref dst, 1) = (byte)((src >> 4) & M);
        }

        /// <summary>
        /// Partitions an 8-bit source value into 2 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part8x4(uint src, Span<byte> dst)
            => part8x4(src, ref head(dst));

        /// <summary>
        /// Partitions the first 12 bits of a 32-bit source value into 3 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part12x4(uint src, ref byte dst)
        {
            const uint M = BitMasks.Lsb8x8x4;

            seek(ref dst, 0) = (byte)((src >> 0) & M);
            seek(ref dst, 1) = (byte)((src >> 4) & M);
            seek(ref dst, 2) = (byte)((src >> 8) & M);
        }

        /// <summary>
        /// Partitions the first 12 bits of a 32-bit source value into 3 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part12x4(uint src, Span<byte> dst)
            => part12x4(src, ref head(dst));


        /// <summary>
        /// Partitions a 16-bit source value into 4 8-bit target segments
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part16x4(ushort src, NatSpan<N4,byte> dst)
        {
            const uint M = BitMasks.Lsb32x8x4;
            dst.Cell<uint>(0) = Bits.scatter(src, M); 
        }

        /// <summary>
        /// Partitions a 32-bit source value into 8 4-bit segments distributed across 8 bytes
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x4(uint src, NatSpan<N8,byte> dst)
        {
            const ulong M = BitMasks.Lsb64x8x4;
            dst.Cell<ulong>(0) = Bits.scatter(src, M); 
        }

        // ~ Nx5
        // ~ ------------------------------------------------------------------


        /// <summary>
        /// Partitions the first 20 bits of a 32-bit source value into 4 8-bit segments of width 5
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline)]
        public static void Part20x5(uint src, NatSpan<N4,byte> dst)
        {
            const uint M = BitMasks.Lsb32x8x5;
            dst.Cell<uint>(0) = Bits.scatter(src, M);            
        }


        // ~ Nx8
        // ~ ------------------------------------------------------------------
 
        /// <summary>
        /// Partitions a 16-bit source value into 2 segments of width 8
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline)]
        public static void part16x8(ushort src, NatSpan<N2,byte> dst)
            => dst.Cell<ushort>(0) = src; 

        /// <summary>
        /// Partitions a 32-bit source value into 4 segments of width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline)]
        public static void part32x8(uint src, NatSpan<N4,byte> dst)
            => dst.Cell<uint>(0) = src; 

        /// <summary>
        /// Partitions a 64-bit source value into 8 segments of width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline)]
        public static void part64x8(ulong src, NatSpan<N8,byte> dst)
            => dst.Cell<ulong>(0) = src; 

        // ~ Nx16
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Partitions a 64-bit source value into 4 segments of width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x16(uint src, NatSpan<N2,ushort> dst)
            => dst.Cell<uint>(0) = src; 

        /// <summary>
        /// Partitions a 64-bit source value into 4 segments of width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part64x16(ulong src, NatSpan<N4,ushort> dst)
            => dst.Cell<ulong>(0) = src; 
 
        // ~ Nx32
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Partitions a 64-bit source value into 2 segments of width 32
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part64x32(ulong src, NatSpan<N2,uint> dst)
            => dst.Cell<ulong>(0) = src;

        /// <summary>
        /// [00000001 ... 00000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        static T lsb8x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), BitMasks.Lsb64x8x1));

        /// <summary>
        /// [00000000 00000000 00000000 0000001 00000000 00000000 00000000 0000001]
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        static T lsb32x1<T>(T src)
            where T : unmanaged
                => convert<ulong,T>(Bits.scatter(convert<T,ulong>(src), BitMasks.Lsb64x32x1));

    }
}