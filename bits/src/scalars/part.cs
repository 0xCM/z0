//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
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
            const uint M1 = 1;
            seek(ref dst, 0) = (byte)(src >> 0 & M1);
            seek(ref dst, 1) = (byte)(src >> 1 & M1);
            seek(ref dst, 2) = (byte)(src >> 2 & M1);
            seek(ref dst, 3) = (byte)(src >> 3 & M1);
        }

        /// <summary>
        /// Partitions the first 5 bits of a 32-bit source into 5 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part5x1(uint src, ref byte dst)
        {
            const uint M1 = 1;
            seek(ref dst, 0) = (byte)(src >> 0 & M1);
            seek(ref dst, 1) = (byte)(src >> 1 & M1);
            seek(ref dst, 2) = (byte)(src >> 2 & M1);
            seek(ref dst, 3) = (byte)(src >> 3 & M1);
            seek(ref dst, 4) = (byte)(src >> 4 & M1);
        }

        /// <summary>
        /// Partitions the first 6 bits of a 32-bit source into 6 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part6x1(uint src, ref byte dst)
        {
            const uint M1 = 1;
            seek(ref dst, 0) = (byte)(src >> 0 & M1);
            seek(ref dst, 1) = (byte)(src >> 1 & M1);
            seek(ref dst, 2) = (byte)(src >> 2 & M1);
            seek(ref dst, 3) = (byte)(src >> 3 & M1);
            seek(ref dst, 4) = (byte)(src >> 4 & M1);
            seek(ref dst, 5) = (byte)(src >> 5 & M1);
        }

        /// <summary>
        /// Partitions the first 7 bits of a 32-bit source into 7 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part7x1(uint src, ref byte dst)
        {
            const uint M1 = 1;
            seek(ref dst, 0) = (byte)(src >> 0 & M1);
            seek(ref dst, 1) = (byte)(src >> 1 & M1);
            seek(ref dst, 2) = (byte)(src >> 2 & M1);
            seek(ref dst, 3) = (byte)(src >> 3 & M1);
            seek(ref dst, 4) = (byte)(src >> 4 & M1);
            seek(ref dst, 5) = (byte)(src >> 5 & M1);
            seek(ref dst, 6) = (byte)(src >> 6 & M1);
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
            const uint M1 = 1;
            part8x1(src, ref dst);
            seek(ref dst, 8) = (byte)(src >> 8 & M1);
        }

        /// <summary>
        /// Partitions the first 10 bits of a 32-bit source into 10 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part10x1(uint src, ref byte dst)
        {
            const uint M1 = 1;
            part9x1(src, ref dst);
            seek(ref dst, 9) = (byte)(src >> 9 & M1);
        }

        [MethodImpl(Inline)]
        public static void part10x1(uint src, Span<byte> dst)
            => part10x1(src, ref head(dst));
        

        /// <summary>
        /// Partitions a 32-bit source into 32 8-bit targets of effective width 1
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x1(uint src, Span<byte> dst)
        {
            ref var target = ref head64(dst);
            seek(ref target, 0) = BitMasks.lsb8x1((ulong)src);
            seek(ref target, 1) = BitMasks.lsb8x1((ulong)src >> 8);
            seek(ref target, 2) = BitMasks.lsb8x1((ulong)src >> 16);
            seek(ref target, 3) = BitMasks.lsb8x1((ulong)src >> 24);
        }

        /// <summary>
        /// Partitions a 64-bit source into 64 8-bit targets of effective width 1
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part64x1(ulong src, Span<byte> dst)
        {
            ref var target = ref head64(dst);
            seek(ref target, 0) = BitMasks.lsb8x1(src);
            seek(ref target, 1) = BitMasks.lsb8x1(src >> 8);
            seek(ref target, 2) = BitMasks.lsb8x1(src >> 16);
            seek(ref target, 3) = BitMasks.lsb8x1(src >> 24);
            seek(ref target, 4) = BitMasks.lsb8x1(src >> 32);
            seek(ref target, 5) = BitMasks.lsb8x1(src >> 40);
            seek(ref target, 6) = BitMasks.lsb8x1(src >> 48);
            seek(ref target, 7) = BitMasks.lsb8x1(src >> 56);
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
                seek(ref target, i) = BitMasks.lsb32x1(src >> i);
        }

        /// <summary>
        /// Partitions the first 8 bits of a 32-bit source into 4 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part8x2(uint src, ref byte dst)
        {
            const uint M2 = 0b11;
            seek(ref dst, 0) = (byte)(src >> 0 & M2);
            seek(ref dst, 1) = (byte)(src >> 2 & M2);
            seek(ref dst, 2) = (byte)(src >> 4 & M2);
            seek(ref dst, 3) = (byte)(src >> 6 & M2);
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
            const uint M3 = 0b111;
            seek(ref dst, 0) = (byte)(src >> 0 & M3);
            seek(ref dst, 1) = (byte)(src >> 3 & M3);
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
            const uint M3 = 0b111;
            part6x3(src, ref dst);
            seek(ref dst, 2) = (byte)(src >> 6 & M3);
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
            const uint M3 = 0b111;
            part9x3(src, ref dst);
            seek(ref dst, 3) = (byte)(src >> 9 & M3);
        }

        /// <summary>
        /// Partitions the first 12 bits of a 32-bit source into 4 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part12x3(uint src, Span<byte> dst)
            => part12x3(src, ref head(dst));

        /// <summary>
        /// Partitions the first 15 bits of a 16-bit source into 6 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part15x3(uint src, ref byte dst)
        {
            const uint M3 = 0b111;
            part12x3(src, ref dst);
            seek(ref dst, 4) = (byte)(src >> 12 & M3);
       }

        /// <summary>
        /// Partitions the first 15 bits of a 32-bit source into 6 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part15x3(uint src, Span<byte> dst)
            => part15x3(src, ref head(dst));


        /// <summary>
        /// Partitions the first 18 bits of a 32-bit source into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part18x3(uint src, ref byte dst)
        {
            const uint M3 = 0b111;
            part15x3(src, ref dst);
            seek(ref dst, 5) = (byte)(src >> 15 & M3);
        }

        /// <summary>
        /// Partitions the first 18 bits of a 32-bit source into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part18x3(uint src, Span<byte> dst)
            => part18x3(src, ref head(dst));

        /// <summary>
        /// Partitions the first 21 bits of a 32-bit source value into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part21x3(uint src, ref byte dst)
        {
            const uint M3 = 0b111;
            part18x3(src, ref dst);
            seek(ref dst, 6) = (byte)(src >> 18 & M3);
        }

        /// <summary>
        /// Partitions the first 21 bits of a 32-bit source value into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part21x3(uint src, Span<byte> dst)
            => part21x3(src, ref head(dst));

        /// <summary>
        /// Partitions the first 24 bits of a 32-bit source value into 8 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part24x3(uint src, ref byte dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;
            seek64(ref dst, 0) = dinx.scatter((ulong)src, M);        
        }

        /// <summary>
        /// Partitions the first 24 bits of a 32-bit source value into 8 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part24x3(uint src, Span<byte> dst)
            => part24x3(src, ref head(dst));

        /// <summary>
        /// Partitions the first 27 bits of a 32-bit source value into 9 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part27x3(uint src, ref byte dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;
            seek64(ref dst, 0) = dinx.scatter((ulong)src, M);
            seek16(ref dst, 4) = (byte)dinx.scatter((ulong)(src >> 24), M);
        }

        /// <summary>
        /// Partitions the first 27 bits of a 32-bit source value into 9 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part27x3(uint src, Span<byte> dst)
            => part27x3(src, ref head(dst));
 
        /// <summary>
        /// Partitions the first 30 bits of a 32-bit source value into 10 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part30x3(uint src, ref byte dst)
        {
            const ulong M = BitMasks.Lsb64x8x3;
            seek64(ref dst, 0) = dinx.scatter((ulong)src, M);
            seek16(ref dst, 4) = (ushort)dinx.scatter((ulong)(src >> 24), M);
        }

        /// <summary>
        /// Partitions the first 30 bits of a 32-bit source value into 10 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part30x3(uint src, Span<byte> dst)
            => part30x3(src, ref head(dst));

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
            const uint M4 = 0b1111;
            seek(ref dst, 0) = (byte)((src >> 0) & M4);
            seek(ref dst, 1) = (byte)((src >> 4) & M4);
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
            const uint M4 = 0b1111;
            seek(ref dst, 0) = (byte)((src >> 0) & M4);
            seek(ref dst, 1) = (byte)((src >> 4) & M4);
            seek(ref dst, 2) = (byte)((src >> 8) & M4);
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
        /// Partitions a 32-bit source value into 4 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part16x4(uint src, ref byte dst)
        {
            const uint M4 = 0b1111;
            seek(ref dst, 0) = (byte)((src >> 0) & M4);
            seek(ref dst, 1) = (byte)((src >> 4) & M4);
            seek(ref dst, 2) = (byte)((src >> 8) & M4);
            seek(ref dst, 3) = (byte)((src >> 12) & M4);
        }

        /// <summary>
        /// Partitions a 16-bit source value into 4 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part16x4(uint src, Span<byte> dst)
            => part16x4(src, ref head(dst));

        [MethodImpl(Inline)]
        public static void part32x4(uint src, ref byte dst)
        {
            part16x4(src, ref dst);
            part16x4(src >> 16, ref seek(ref dst, 4));
        }

        /// <summary>
        /// Partitions a 32-bit source value into 8 segments with an effective bit width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x4(uint src, Span<byte> dst)
            => part32x4(src, ref head(dst));

        // ~ Nx8
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Partitions the source value into 2 segments of width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part16x8(ushort src, ref byte dst)
            => uint16(ref dst) = src;

        /// <summary>
        /// Partitions the source value into 2 segments of width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part16x8(ushort src, Span<byte> dst)
            => head16(dst) = src;
 
        /// <summary>
        /// Partitions a 32-bit source value into 4 segments of bit width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x8(uint src, ref byte dst)
            => uint32(ref dst) = src;

        /// <summary>
        /// Partitions a 32-bit source value into 4 segments of width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline)]
        public static void part32x8(uint src, Span<byte> dst)
            => head32(dst) = src;

        /// <summary>
        /// Partitions a 64-bit source value into 8 segments of width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline)]
        public static void part64x8(ulong src, ref byte dst)
            => uint64(ref dst) = src;

        /// <summary>
        /// Partitions a 64-bit source value into 8 segments of width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The partition target</param>
        [MethodImpl(Inline)]
        public static void part64x8(ulong src, Span<byte> dst)
            => head64(dst) = src;

        // ~ Nx16
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Partitions a 32-bit source value into 2 segments of width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x16(uint src, Span<ushort> dst)
            => head32(dst) = src;
        
        /// <summary>
        /// Partitions a 64-bit source value into 4 segments of width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part64x16(ulong src, Block64<ushort> dst)
            => head64(dst) = src; 
 
        // ~ Nx32
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// Partitions a 64-bit source value into 2 segments of width 32
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part64x32(ulong src, Span<uint> dst)
            => head64(dst) = src;

        /// <summary>
        /// Partitions a 64-bit source value into 2 segments of width 32
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part64x32(ulong src, ref uint dst)
            => uint64(ref dst) = src;
    }
}