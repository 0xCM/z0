//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static BitSpan8 init(Span<byte> src)
            => new BitSpan8(src);
            
        /// <summary>
        /// Wraps a bitspan over a span of extant bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static BitSpan load(Span<bit> src)
            => new BitSpan(src);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline), Op]
        public static BitSpan load(bit[] src)
            => new BitSpan(src);
        
        /// <summary>
        /// Loads a bitspan from a reference
        /// </summary>
        /// <param name="bits">The bit source</param>
        /// <param name="count">The number of bits to load</param>
        [MethodImpl(Inline), Op]
        public static BitSpan load(ref bit bits, int count)        
            => new BitSpan(cover(bits,count));                                   

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [Op]
        internal static BitSpan load(ReadOnlySpan<byte> packed)
        {               
            var srcbits = 8*packed.Length;
            var dstbits = 32*srcbits;
            var blocks = dstbits/256 + (dstbits % 256 == 0 ? 0 : 1);        
            var dst = Blocks.alloc<uint>(n256,blocks);

            for(var block=0; block<blocks; block++)
                BitPack.unpack(packed, dst, block);

            return load(dst.As<bit>());            
        }

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        internal static BitSpan load(Span<byte> packed)
            => load(packed.ReadOnly());        
    }
}