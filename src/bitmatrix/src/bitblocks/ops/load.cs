//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class BitBlocks
    {
        /// <summary>
        /// Converts the source bitvector to bit cells
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N8,byte> load(BitVector8 src)
            => new BitBlock<N8, byte>(src);

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N16,ushort> load(BitVector16 src)
            => new BitBlock<N16, ushort>(src);

        /// <summary>
        /// Converts the source bitvector to an equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N32,uint> load(BitVector32 src)
            => new BitBlock<N32, uint>(src);

        /// <summary>
        /// Converts the source bitvector it the equivalent natural/generic bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static BitBlock<N64,ulong> load(BitVector64 src)
            => new BitBlock<N64, ulong>(src);


        /// <summary>
        /// Loads a bitblock from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The cell count</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<T> load<T>(Span<T> src, int n)
            where T : unmanaged
                => new BitBlock<T>(src, (uint)n);

        /// <summary>
        /// Loads a bitblock from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The bitblock width representative</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> load<N,T>(T[] src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitBlock<N,T>(src);

        /// <summary>
        /// Creates a bitblock over an arbitrary number of segments
        /// </summary>
        /// <param name="src">The source segment</param>
        [MethodImpl(Inline)]
        public static BitBlock<T> load<T>(params T[] src)
            where T : unmanaged
                => new BitBlock<T>(src, bitwidth<T>()*(uint)src.Length);

        /// <summary>
        /// Loads a natural bitcell container from a span
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitblock width representative</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> load<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitBlock<N,T>(src);

        /// <summary>
        /// Loads a natural bitblock from a readonly span; allocation required
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="N">The bitwidth type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<N,T> load<N,T>(ReadOnlySpan<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitBlock<N,T>(src.ToSpan());

        [MethodImpl(Inline)]
        public static BitBlock<N,T> load<N,T>(Span<byte> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitBlock<N,T>(src.Recover<byte,T>());

        /// <summary>
        /// Creates a bitvector from a span of bytes
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The bitvector length</param>
        static BitBlock<T> load<T>(Span<byte> src, uint n)
            where T : unmanaged
        {
            var q = Math.DivRem(src.Length, (int)z.size<T>(), out int r);
            var cellcount = r == 0 ? q : q + 1;
            var capacity = (int)z.size<T>();
            var cells = new T[cellcount];
            for(int i=0, offset = 0; i<cellcount; i++, offset += capacity)
                cells[i] = src.Slice(offset).Take<T>();
            return new BitBlock<T>(cells, n);
        }
    }
}