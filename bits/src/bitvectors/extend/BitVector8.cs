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
        /// Constructs a canonical 8-bit bitvector from an 8-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this byte src)
            => src;

        /// <summary>
        /// Constructs an 8-bit bitvector from a sequence of bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector<T>(this BitCells<T> src, N8 n)        
            where T : unmanaged
                => src.Data.TakeUInt8();

        /// <summary>
        /// Constructs a 8-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector(this BitString src, N8 n)
            => BitVector.from(n,src);

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<byte> ToGeneric(this BitVector8 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitCells<N8,byte> ToCells(this BitVector8 src)
            => src;
    
        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 Reverse(this BitVector8 src)
            => BitVector.rev(src);

        /// <summary>
        /// Computes the smallest integer n > 1 such that v^n = identity
        /// </summary>
        [MethodImpl(Inline)]
        public static int Order(this BitVector8 src)
            => BitVector.ord(src);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector8 Replicate(this BitVector8 src)
            => src.data;

        /// <summary>
        /// Creates a new vector via concatenation
        /// </summary>
        /// <param name="tail">The lower bits of the new vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 Concat(this BitVector8 head, BitVector8 tail)
            => BitVector16.FromScalars(tail.data, head.data);

        [MethodImpl(Inline)]
        public static BitVector16 Replicate(this BitVector8 src, N2 n)
            => src.Concat(src);

        [MethodImpl(Inline)]
        public static BitVector32 Replicate(this BitVector8 src, N4 n)
            => src.Replicate(n2).Replicate(n2);

        [MethodImpl(Inline)]
        public static BitVector64 Replicate(this BitVector8 src, N8 n)
            =>src.Replicate(n4).Replicate(n2);

        /// <summary>
        /// Returns the vector's bitstring representation
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector8 src)
            => src.data.ToBitString();

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector8 src, bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
            => src.ToBitString().Format(tlz, specifier, blockWidth, blocksep);

    }

}