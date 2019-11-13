//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Bits;

    partial class BitParts
    {        
        const uint M4 = 0b1111;

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part8x4 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x4 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part16x4 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part20x4 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part24x4 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x4 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x4 part)
            => select(src, (ulong)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x4 part)
            => project(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x4 part)
            => project(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x4 part)
            => project(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x4 part)
            => project(src, (uint)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part64x4 part)
            => project(src, (ulong)part);

        /// <summary>
        /// Partitions an 8-bit source value into 2 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part8x4(uint src, ref byte dst)
        {
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

    }
}