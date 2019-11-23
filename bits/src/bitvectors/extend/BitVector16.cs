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
        /// <summary>
        /// Constructs a 16-bit bitvector from a 16-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this ushort src)
            => src;

        /// <summary>
        /// Creates a 16-bit bitvector from a 16-bit scalar
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this short src, N16 n)        
            => (ushort)src;

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
            => BitVector16.FromBitString(src);

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
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> ToNatural(this BitVector16 src)
            => src;

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 Reverse(this BitVector16 src)
            => BitVector.rev(src);

    }

}