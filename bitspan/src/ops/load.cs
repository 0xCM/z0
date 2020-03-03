//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;

    partial struct BitSpan
    {
        /// <summary>
        /// Creates a bitspan from an arbitrary number of primal values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan load<T>(Span<T> packed)
            where T : unmanaged
                => load(packed.AsBytes());

        /// <summary>
        /// Creates a bitspan from an arbitrary number of primal values
        /// </summary>
        /// <param name="packed">The packed data source</param>
        [MethodImpl(Inline)]
        public static BitSpan load<T>(ReadOnlySpan<T> packed)
            where T : unmanaged
                => load(packed.AsBytes());

        /// <summary>
        /// Wraps a bitspan over a span of extant bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitSpan load(Span<bit> src)
            => new BitSpan(src);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static BitSpan load(bit[] src)
            => new BitSpan(src);
        
        /// <summary>
        /// Loads a bitspan from a reference
        /// </summary>
        /// <param name="bits">The bit source</param>
        /// <param name="count">The number of bits to load</param>
        [MethodImpl(Inline)]
        public static BitSpan load(ref bit bits, int count)        
            => new BitSpan(MemoryMarshal.CreateSpan(ref bits,count));                                   

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        static BitSpan load(ReadOnlySpan<byte> packed)
        {            
            const int blocklen = 8;

            var blockcount = packed.Length;
            var unpacked = Blocks.alloc(n256, blockcount, z32);
            for(var block=0; block < blockcount; block++)
                bitpack.unpack32(packed, unpacked,block);
            return load(unpacked.As<bit>());
        }

        /// <summary>
        /// Creates a bitspan from an arbitrary number of packed bytes
        /// </summary>
        /// <param name="packed">The packed data source</param>
        static BitSpan load(Span<byte> packed)
            => load(packed.ReadOnly());
    }
}