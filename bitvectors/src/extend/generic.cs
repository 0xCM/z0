//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class BitVectorX
    {
        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<byte> ToGeneric(this BitVector8 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<ushort> ToGeneric(this BitVector16 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<uint> ToGeneric(this BitVector32 src)
            => src.data;

        /// <summary>
        /// Converts the source bitvector to an equivalent generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector<ulong> ToGeneric(this BitVector64 src)
            => src.data;

        /// <summary>
        /// Creates a 16-bit bitvector from the leading cells of a source block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ushort> ToBitVector<T>(this in Block16<T> src)
            where T : unmanaged
                => src.Data.TakeUInt16();

        /// <summary>
        /// Creates a 16-bit bitvector from the leading cells of a source block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<uint> ToBitVector<T>(this in Block32<T> src)
            where T : unmanaged
                => src.Data.TakeUInt32();

        /// <summary>
        /// Creates a 64-bit bitvector from the leading cells of a source block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ulong> ToBitVector<T>(this in Block64<T> src, N64 n)
            where T : unmanaged
                => src.Data.TakeUInt64();

        /// <summary>
        /// Creates an 8-bit bitvector from the leading cells of a source block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<byte> ToBitVector<T>(this in Block256<T> src, N8 n)
            where T : unmanaged
                => src.Data.TakeUInt8();

        /// <summary>
        /// Creates a 16-bit bitvector from the leading cells of a source block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ushort> ToBitVector<T>(this in Block256<T> src, N16 n)
            where T : unmanaged
                => src.Data.TakeUInt16();

        /// <summary>
        /// Creates a 32-bit bitvector from the leading cells of a source block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<uint> ToBitVector<T>(this in Block256<T> src, N32 n)
            where T : unmanaged
                => src.Data.TakeUInt32();

        /// <summary>
        /// Creates a 64-bit bitvector from the leading cells of a source block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="n">The target width selector</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ulong> ToBitVector<T>(this in Block256<T> src, N64 n)
            where T : unmanaged
                => src.Data.TakeUInt64();

    }
}