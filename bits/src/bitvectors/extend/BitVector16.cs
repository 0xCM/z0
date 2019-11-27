//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector<T>(this BitCells<T> src, N16 n)
            where T : unmanaged
                => src.Data.TakeUInt16();

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<ushort> ToGeneric(this BitVector16 src)
            => src.data;

        /// <summary>
        /// Constructs a 16-bit bitvector from a 16-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this ushort src, N16 n = default)
            => src;

        /// <summary>
        /// Creates a 16-bit bitvector with the lower 8 bits populated by the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this byte src, N16 n)        
            => src;

        /// <summary>
        /// Constructs a 16-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this BitString src, N16 n)
            => src.TakeUInt16();

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitCells<N16,ushort> ToCells(this BitVector16 src)
            => src;

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 Reverse(this BitVector16 src)
            => BitVector.rev(src);

        [MethodImpl(Inline)]
        public static BitVector32 Concat(this BitVector16 head, BitVector16 tail)
            => BitVector.from(n32,tail.data, head.data);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector16 Replicate(this BitVector16 x)
            => x.data;

        [MethodImpl(Inline)]
        public static BitVector32 Replicate(this BitVector16 x, N2 n)
            => x.Concat(x);

        /// <summary>
        /// Returns the vector's bitstring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector16 src)
            => BitVector.bitstring(src);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector16 src, BitFormat? fmt = null)
            => BitVector.format(src, fmt);

    }

}