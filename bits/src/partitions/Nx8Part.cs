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
    using static As;

    partial class BitParts
    {        
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
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x8 part)
            => select(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x8 part)
            => select(src, (ulong)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x8 part)
            => Bits.scatter(src, (uint)part);  

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x8 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ulong project(ulong src, Part64x8 part)
            => project(src, (ulong)part);
 
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
            
    }
}