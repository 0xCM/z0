//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;

    partial class BitParts
    {        
        const uint M1 = 1;

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part2x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part3x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part4x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part5x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part6x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part7x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part8x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part9x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part10x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part11x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part13x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part16x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x1 spec)
            => select(src, (uint)spec);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">Identifies the source bits to collect</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x1 spec)
            => select(src, (ulong)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part2x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part3x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part4x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part5x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part6x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part9x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part7x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part11x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low bits in a source to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part13x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low bits in a source to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low bits in a source to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x1 spec)
            => project(src, (uint)spec);

        /// <summary>
        /// Maps low bits in a source to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The target bits to populate</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part64x1 spec)
            => project(src, (ulong)spec);

        /// <summary>
        /// Partitions the first 4 bits of a 32-bit source into 4 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        public static void part4x1(uint src, ref byte dst)
        {
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
            part9x1(src, ref dst);
            seek(ref dst, 9) = (byte)(src >> 9 & M1);
        }

        /// <summary>
        /// Partitions the first 10 bits of a 32-bit source into 10 8-bit targets of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
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
            => part32x1(src, ref head64(dst));

        /// <summary>
        /// Partitions a 64-bit source into 64 8-bit targets of effective width 1
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part64x1(ulong src, Span<byte> dst)
            => part64x1(src, ref head64(dst));
 
        /// <summary>
        /// Partitions a 64-bit source value into 64 individual bit values
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static void part64x1(ulong src, Span<bit> dst)
        {
            ref var target = ref head(dst);
            for(var i=0; i<64; i++)
                seek(ref target, i) = Bits.test(src,i);
        }

        /// <summary>
        /// Partitions a 32-bit source into 32 8-bit targets of effective width 1
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        static void part32x1(uint src, ref ulong dst)
        {                    
            const ulong M = (ulong)Lsb64x8.Select;
            seek(ref dst, 0) = project(select(src, Part32x8.Part0), M);
            seek(ref dst, 1) = project(select(src, Part32x8.Part1), M);
            seek(ref dst, 2) = project(select(src, Part32x8.Part2), M);
            seek(ref dst, 3) = project(select(src, Part32x8.Part3), M);            
        }

        /// <summary>
        /// Partitions a 64-bit source into 64 8-bit targets of effective width 1
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target memory location</param>
        [MethodImpl(Inline)]
        static void part64x1(ulong src, ref ulong dst)            
        {
            const ulong M = (ulong)Lsb64x8.Select;
            seek(ref dst, 0) = project(select(src, Part64x8.Part0), M);
            seek(ref dst, 1) = project(select(src, Part64x8.Part1), M);
            seek(ref dst, 2) = project(select(src, Part64x8.Part2), M);
            seek(ref dst, 3) = project(select(src, Part64x8.Part3), M);
            seek(ref dst, 4) = project(select(src, Part64x8.Part4), M);
            seek(ref dst, 5) = project(select(src, Part64x8.Part5), M);
            seek(ref dst, 6) = project(select(src, Part64x8.Part6), M);
            seek(ref dst, 7) = project(select(src, Part64x8.Part7), M);
        }
    }
}