//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitSpan;

    public static class BitSpanX
    {
        /// <summary>
        /// Wraps a bitspan over a span of extant bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this Span<bit> src)
            => load(src);

        /// <summary>
        /// Loads a natspan from a bitspan (nonallocating)
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The length representative</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static NatSpan<N,bit> ToNatSpan<N>(this in BitSpan src, N n = default)
            where N : unmanaged, ITypeNat
                => NatSpan.load(src.Bits,n);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
        public static BitSpan ToBitSpan(this bit[] src)
            => load(src);

        /// <summary>
        /// Obliterates all bitspan content
        /// </summary>
        /// <param name="src">The source bits</param>
        public static ref readonly BitSpan Clear(this in BitSpan src)
        {
            clear(src);        
            return ref src;
        }

        /// <summary>
        /// Clears a contiguous sequence of bits between two indices
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="i0">The index of the first bit to clear</param>
        /// <param name="i1">The index of the last bit to clear</param>
        public static ref readonly BitSpan Clear(this in BitSpan src, int i0, int i1)
        {
            clear(src, i0, i1);        
            return ref src;
        }

        [MethodImpl(Inline)]
        public static BitSpan Replicate(this in BitSpan src, int copies = 1)
            => replicate(src,copies);
    }

}