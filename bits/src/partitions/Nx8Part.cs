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
        /// <summary>
        /// Partitions the first 16 bits of an unsigned 32-bit integer into 2 target segments each with a width of 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part16x8(uint src, ref byte dst)
        {
            seek(ref dst, 0) = (byte)((src >> 0) & 0xFF);
            seek(ref dst, 1) = (byte)((src >> 8) & 0xFF);
        }

        /// <summary>
        /// Partitions the first 16 bits of an unsigned 32-bit integer into 2 target segments each with a width of 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part16x8(uint src, Span<byte> dst)
            => part16x8(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x8 part)
            => Bits.scatter(src, (uint)part);  
 
        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part16x8 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part24x8 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Partitions a 32-bit source value into 4 segments of bit width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part32x8(uint src, ref byte dst)
        {
            seek(ref dst, 0) = (byte)((src >> 0) & 0xFF);
            seek(ref dst, 1) = (byte)((src >> 8) & 0xFF);
            seek(ref dst, 2) = (byte)((src >> 16) & 0xFF);
            seek(ref dst, 3) = (byte)((src >> 24) & 0xFF);
        }


        /// <summary>
        /// Partitions a 32-bit source value into 4 segments of bit width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part32x8(uint src, Span<byte> dst)
            => part32x8(src, ref head(dst));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x8 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(uint src, Part32x8 part)
            => (byte)Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part64x8 part)
            => Bits.scatter(src, (ulong)part);
 
        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(ulong src, Part64x8 part)
            => (byte)Bits.gather(src, (ulong)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part64x8 part)
            => Bits.gather(src, (uint)part);

    }
}