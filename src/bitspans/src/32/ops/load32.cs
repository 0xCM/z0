//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class BitSpans
    {
        /// <summary>
        /// Wraps a bitspan over a span of extant bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 load32(Span<Bit32> src)
            => new BitSpan32(src);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 load32(Bit32[] src)
            => new BitSpan32(src);

        /// <summary>
        /// Loads a bitspan from a reference
        /// </summary>
        /// <param name="bits">The bit source</param>
        /// <param name="count">The number of bits to load</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 load32(ref Bit32 bits, int count)
            => new BitSpan32(cover(bits,count));

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [Op]
        internal static BitSpan32 load32(ReadOnlySpan<byte> packed)
        {
            var srcbits = 8*packed.Length;
            var dstbits = 32*srcbits;
            var blocks = dstbits/256 + (dstbits % 256 == 0 ? 0 : 1);
            var dst = SpanBlocks.alloc<uint>(n256,blocks);

            for(var block=0; block<blocks; block++)
                gpack.unpack1x32(packed, dst, block);

            return load32(dst.As<Bit32>());
        }

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        internal static BitSpan32 load32(Span<byte> packed)
            => load32(packed.ReadOnly());
    }
}