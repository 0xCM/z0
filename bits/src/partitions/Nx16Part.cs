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
        /// Partitions a 32-bit source value into 2 segments of bit width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x16(uint src, Span<ushort> dst)
        {
            dst[0] = (ushort)src;
            dst[1] = (ushort)(src >> 16);
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

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x16 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x16 part)
            => Bits.gather(src, (uint)part);

    }
}