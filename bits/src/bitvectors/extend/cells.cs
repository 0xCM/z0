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
        /// Constructs a 16-bit bitvector from a sequence of bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector<T>(this BitCells<T> src, N16 n)
            where T : unmanaged
                => src.Data.TakeUInt16();

        /// <summary>
        /// Constructs a 32-bit bitvector from a sequence of bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector<T>(this BitCells<T> src, N32 n)
            where T : unmanaged
                => src.Data.TakeUInt32();

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
        /// Converts the source bitvector to bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitCells<N8,byte> ToBitCells(this BitVector8 src)
            => src;

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitCells<N16,ushort> ToBitCells(this BitVector16 src)
            => src;

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitCells<N64,ulong> ToBitCells(this BitVector64 src)
            => src;

        /// <summary>
        /// Extracts the bitcells froma span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="len">The bitvector length, if specified</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> ToBitCells<T>(this Span<T> src, int len)
            where T : unmanaged
                => BitCells.load(src,len);

        /// <summary>
        /// Extracts the bitcells from a source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitCells<T> ToBitCells<T>(this BitVector<T> src)
            where T : unmanaged
                => BitCells.literals(src.Scalar);

        [MethodImpl(Inline)]
        public static BitCells<N,T> ToBitCells<N,T>(this BitVector128<N,T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitCells.load(src.data.ToSpan(),n);
    }
}