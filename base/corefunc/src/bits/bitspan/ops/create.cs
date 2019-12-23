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

    partial struct BitSpan
    {
        /// <summary>
        /// Allocates a bitspan with a specified length
        /// </summary>
        /// <param name="len">The length of the bitstring</param>
        public static BitSpan alloc(int len)
            => new BitSpan(new bit[len]);

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
        /// Obliterates all bitspan content
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ref readonly BitSpan clear(in BitSpan src)
        {
            src.bits.Clear();
            return ref src;
        }

        /// <summary>
        /// Clears a contiguous sequence of bits between two indices
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="i0">The index of the first bit to clear</param>
        /// <param name="i1">The index of the last bit to clear</param>
        [MethodImpl(Inline)]
        public static ref readonly BitSpan clear(in BitSpan src, int i0, int i1)
        {
            src.bits.Slice(i0, i0 - i1 + 1).Clear();
            return ref src;
        }

        /// <summary>
        /// Creates a bitspan from a parameter array
        /// </summary>
        /// <param name="src">The sorce bits</param>
        [MethodImpl(Inline)]
        public static BitSpan parts(params bit[] src)
            => new BitSpan(src);
    }
}