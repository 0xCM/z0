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
        /// Constructs a 64-bit bitvector from a 64-bit primal value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ulong src)
            => src;

        /// <summary>
        /// Constructs a 64-bit bitvector from bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this BitString src, N64 n)
            => BitVector.from(n,src);

        /// <summary>
        /// Constructs a 64-bit bitvector from a sequence of bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector<T>(this BitCells<T> src, N64 n)
            where T : unmanaged
                => src.Data.TakeUInt64();

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<ulong> ToGeneric(this BitVector64 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> ToNatural(this BitVector64 src)
            => src;

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv32
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector32 Narrow(this BitVector64 src, N32 n)
            => BitVector.from(n,src.data);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv8
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector8 Narrow(this BitVector64 src, N8 n)
            => BitVector8.FromScalar(src.data);

        /// <summary>
        /// Applies a truncating reduction Bv64 -> Bv16
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector16 Narrow(this BitVector64 src, N16 n)
            => BitVector16.FromScalar(src.data);

        /// <summary>
        /// Applies a widening conversion Bv64 -> Bv128
        /// </summary>
        [MethodImpl(Inline)]
        public static BitVector128 Expand(this BitVector64 src, N128 n)
            => BitVector.from(n,src.data);


    }

}