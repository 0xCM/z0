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
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x16 part)
            => select(src, (uint)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part48x16 part)
            => select(src, (ulong)part);

        /// <summary>
        /// Maps mask-identified source bits to the low bits of an empty target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, Part64x16 part)
            => select(src, (ulong)part);

        /// <summary>
        /// Maps low source bits to mask-identified bits of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x16 part)
            => project(src, (uint)part);

        /// <summary>
        /// Partitions a 32-bit source value into 2 segments of bit width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x16(uint src, Span<ushort> dst)
        {
            seek(dst,0) = (ushort)src;
            seek(dst,1) = (ushort)(src >> 16);
        }
        
        /// <summary>
        /// Partitions a 32-bit source value into 2 segments of bit width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x16(uint src, out ushort x0, out ushort x1)
        {
            x0 = (ushort)src;
            x1 = (ushort)(src >> 16);
        }
    }
}