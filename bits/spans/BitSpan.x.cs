//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;
    using static BitSpan;

    public static partial class BitSpanX
    {
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
        /// Obliterates all bitspan content
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public static ref readonly BitSpan Clear(this in BitSpan src, int i0, int i1)
        {
            clear(src, i0, i1);        
            return ref src;
        }

        /// <summary>
        /// Replicates the source content into a new bitspan
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="count">The number of source copies to produce</param>
        [MethodImpl(Inline)]
        public static BitSpan Replicate(this in BitSpan src, int copies = 1)
            => replicate(src,copies);
        
        /// <summary>
        /// Computes the number of enabled bits covered by source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int PopCount(this in BitSpan src)
            => pop(src);
            
        /// <summary>
        /// Extracts and packs bitsize[T] source bits; will fail if data are insufficent
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="t">A target scalar type representative</param>
        /// <typeparam name="T">The target scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T Extract<T>(this in BitSpan src, T t = default)
            where T : unmanaged
                => BitSpan.extract<T>(src);
        
        /// <summary>
        /// Extracts a T-valued scalar (or portion thereof) from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this in BitSpan src)
            where T : unmanaged
                => BitSpan.bitslice<T>(src);
    
        /// <summary>
        /// Extracts a T-valued scalar (or portion thereof) from the source segment [offset,..,offset - (bitsize[T] - 1)]
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="offset">The index of the first bit</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T BitSlice<T>(this in BitSpan src, int offset)
            where T : unmanaged
                => BitSpan.bitslice<T>(src, offset);

        [MethodImpl(Inline)]
        public static T BitSlice<T>(this in BitSpan src, int offset, int count)
            where T : unmanaged 
                => BitSpan.bitslice<T>(src, offset, count);

        /// <summary>
        /// Eliminates leading zeroes, if any, from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitSpan Trim(this in BitSpan src)
            => BitSpan.trim(src);

        /// <summary>
        /// Clamps the source bitstring to one of a specified maximum length, discarding any excess
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="maxbits">The maximum length of the target bitstring</param>
        [MethodImpl(Inline)]
        public static BitSpan Truncate(this in BitSpan src, int maxbits)
            => BitSpan.truncate(src,maxbits);

        /// <summary>
        /// Concatenates two bitspans
        /// </summary>
        /// <param name="head">The leading bits</param>
        /// <param name="tail">The trailing bits</param>
        [MethodImpl(Inline)]
        public static BitSpan Concat(this in BitSpan head, in BitSpan tail)
            => BitSpan.concat(head,tail);
    }
}