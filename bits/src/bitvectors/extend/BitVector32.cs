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
        /// Constructs a canonical 32-bit bitvector from a 32-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this uint src)
            => src;

        /// <summary>
        /// Defines a 32-bit bitvector with content determined by its corresponding integral type 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this uint src, N32 n)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this BitString src, N32 n)
            => BitVector.from(n, src);

        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector<T>(this BitCells<T> src, N32 n)
            where T : unmanaged
                => src.Data.TakeUInt32();

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<uint> ToGeneric(this BitVector32 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> ToNatural(this BitVector32 src)
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this sbyte src, N32 n)        
            => (byte)src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this byte src, N32 n)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this ushort src, N32 n)        
            => src;

        /// <summary>
        /// Constructs a 32-bit bitvector an integer source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector32(this short src, N32 n)        
            => (ushort)src;

        /// <summary>
        /// Applies a truncating reduction Bv32 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector8 Narrow(this BitVector32 src, N8 n)
            => BitVector8.FromScalar(src.data);

        /// <summary>
        /// Applies a truncating reduction Bv32 -> Bv16
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector16 Narrow(this BitVector32 src, N16 n)
            => BitVector16.FromScalar(src.data);

        /// <summary>
        /// Applies the bit width promotion Bv32 -> Bv64
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector64 Expand(this BitVector32 src, N64 n)
            => BitVector.from(n64, src.data);

        /// <summary>
        /// Returns a copy of the vector
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector32 Replicate(this BitVector32 src)
            => new BitVector32(src.data);

        /// <summary>
        /// Returns true of all bits are enabled, false otherwise
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bit TestC(this BitVector32 src)
            => (UInt32.MaxValue & src.data) == UInt32.MaxValue;

        /// <summary>
        /// Rearranges the vector in-place as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation</param>
        [MethodImpl(Inline)]
        public static ref BitVector32 Permute(this ref BitVector32 src, Perm spec)
        {
            BitVector.perm(ref src, spec);
            return ref src;
        }


        /// <summary>
        /// Applies a permutation to a replicated vector
        /// </summary>
        /// <param name="p">The permutation</param>
        [MethodImpl(Inline)]
        public static BitVector32 Replicate(this BitVector32 src, Perm p)
        {
            var dst = src.Replicate();
            BitVector.perm(ref src, p);
            return dst;
        }

        [MethodImpl(Inline)]
        public static BitString ToBitString(this BitVector32 src)
            => src.data.ToBitString();

        /// <summary>
        /// Reverses the vector bits
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 Reverse(this BitVector32 src)
            => BitVector.rev(src);

        /// <summary>
        /// Formats the bitvector as a bitstring
        /// </summary>
        /// <param name="tlz">True if leadzing zeros should be trimmed, false otherwise</param>
        /// <param name="specifier">True if the prefix specifier '0b' should be prepended</param>
        /// <param name="blockWidth">The width of the blocks, if any</param>
        [MethodImpl(Inline)]
        public static string Format(this BitVector32 src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier, blockWidth);
    }

}