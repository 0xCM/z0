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
    using static As;

    partial class BitGrid
    {        
        /// <summary>
        /// Extracts an index-identifed 1-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit row<T>(BitGrid16<N16,N1,T> g, int index)
            where T : unmanaged
                => Bits.extract(g, index*1, 1) == 1;

        /// <summary>
        /// Extracts an index-identifed 8-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> row<T>(BitGrid16<N2,N8,T> g, int index)
            where T : unmanaged
                => (byte)Bits.extract(g, index*8, 8);


        /// <summary>
        /// Extracts an index-identifed 2-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N2,byte> row<T>(BitGrid16<N8,N2,T> g, int index)
            where T : unmanaged
                => (byte)Bits.extract(g, index*2, 2);

        /// <summary>
        /// Extracts an index-identifed 4-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...3</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> row<T>(BitGrid16<N4,N4,T> g, int index)
            where T : unmanaged
                => (byte)Bits.extract(g, index*4, 4);

        /// <summary>
        /// Extracts an index-identifed 1-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...31</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit row<T>(BitGrid32<N32,N1,T> g, int index)
            where T : unmanaged
                => Bits.extract(g, index*1, 1) == 1;

        /// <summary>
        /// Extracts an index-identifed 2-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N2,byte> row<T>(BitGrid32<N16,N2,T> g, int index)
            where T : unmanaged
                => (byte)Bits.extract(g, index*2, 2);

        /// <summary>
        /// Extracts an index-identifed 4-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> row<T>(BitGrid32<N8,N4,T> g, int index)
            where T : unmanaged
                => (byte)Bits.extract(g, index*4, 4);


        /// <summary>
        /// Extracts an index-identifed 8-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...3</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> row<T>(BitGrid32<N4,N8,T> g, int index)
            where T : unmanaged
                => (byte)Bits.extract(g, index*8, 8);

        /// <summary>
        /// Extracts an index-identifed 16-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> row<T>(BitGrid32<N2,N16,T> g, int index)
            where T : unmanaged
                => (ushort)Bits.extract(g, index*16, 16);

        /// <summary>
        /// Presents grid content as a bitvector
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">Irrelevant</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> row<T>(BitGrid32<N1,N32,T> g, int index)
            where T : unmanaged
                => g.Data;

        /// <summary>
        /// Extracts an index-identifed 1-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...63</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit row<T>(BitGrid64<N64,N1,T> g, int index)
            where T : unmanaged
                => Bits.extract(g, index*1, 1) == 1;

        /// <summary>
        /// Extracts an index-identifed 2-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...31</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N2,byte> row<T>(BitGrid64<N32,N2,T> g, int index)
            where T : unmanaged
            => (byte)Bits.extract(g, index*2, 2);

        /// <summary>
        /// Extracts an index-identifed 32-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> row<T>(BitGrid64<N2,N32,T> g, int index)
            where T : unmanaged
                => (uint)Bits.extract(g, index*32,32);

        /// <summary>
        /// Extracts an index-identifed row 4-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> row<T>(BitGrid64<N16,N4,T> g, int index)
            where T : unmanaged
            => (byte)Bits.extract(g, index*4, 4);

        /// <summary>
        /// Extracts an index-identifed row 16-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...3</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> row<T>(BitGrid64<N4,N16,T> g, int index)
            where T : unmanaged
                => (ushort)Bits.extract(g,index*16, 16);

        /// <summary>
        /// Extracts an index-identifed 8-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index in the range [0...7]</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> row<T>(BitGrid64<N8,N8,T> g, int index)
            where T : unmanaged
                => (byte)Bits.extract(g,index*8, 8);

        /// <summary>
        /// Extracts an index-identifed 64-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> row<T>(in BitGrid128<N2,N64,T> g, int index)
            where T : unmanaged
                => v64u(g.Data).GetElement(index);

        /// <summary>
        /// Extracts an index-identifed 32-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index in the range [0...3]</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> row<T>(in BitGrid128<N4,N32,T> g, int index)
            where T : unmanaged
                => v32u(g.Data).GetElement(index);

        /// <summary>
        /// Extracts an index-identifed 16-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index in the range [0...7]</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> row<T>(in BitGrid128<N8,N16,T> g, int index)
            where T : unmanaged
                => v16u(g.Data).GetElement(index);

        /// <summary>
        /// Extracts an index-identifed 8-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index in the range [0...15]</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> row<T>(in BitGrid128<N16,N8,T> g, int index)
            where T : unmanaged
                => v8u(g.Data).GetElement(index);

        /// <summary>
        /// Extracts an index-identifed 64-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index in the range [0...3]</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> row<T>(in BitGrid256<N4,N64,T> g, int index)
            where T : unmanaged
                => v64u(g.Data).GetElement(index);

        /// <summary>
        /// Extracts an index-identifed 32-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index in the range [0...7]</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> row<T>(in BitGrid256<N8,N32,T> g, int index)
            where T : unmanaged
                => v32u(g.Data).GetElement(index);

        /// <summary>
        /// Extracts an index-identifed 8-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index in the range [0...31]</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> row<T>(in BitGrid256<N32,N8,T> g, int index)
            where T : unmanaged
                => v8u(g.Data).GetElement(index);

        /// <summary>
        /// Extracts an index-identifed 16-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index in the range [0...15]</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> row<T>(in BitGrid256<N16,N16,T> g, int index)
            where T : unmanaged
                => v16u(g.Data).GetElement(index);

        [MethodImpl(Inline)]
        public static BitVector<N,T> nrow<M,N,T>(BitGrid16<M,N,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => generic<T>(Bits.extract(g.Data, natval<N>()*index,natval<N>()));

        [MethodImpl(Inline)]
        public static BitVector<N,T> nrow<M,N,T>(BitGrid32<M,N,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => generic<T>(Bits.extract(g.Data, natval<N>()*index,natval<N>()));

        [MethodImpl(Inline)]
        public static BitVector<N,T> nrow<M,N,T>(BitGrid64<M,N,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => generic<T>(Bits.extract(g.Data, natval<N>()*index,natval<N>()));

        [MethodImpl(Inline)]
        public static BitVector<N,T> row<N,T>(BitGrid16<T> g, int index, N width = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => generic<T>(Bits.extract(g.Data, index* natval<N>(), natval<N>()));

        [MethodImpl(Inline)]
        public static BitVector<N,T> row<N,T>(BitGrid32<T> g, int index, N width = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => generic<T>(Bits.extract(g.Data, index* natval<N>(), natval<N>()));

        [MethodImpl(Inline)]
        public static BitVector<N,T> row<N,T>(BitGrid64<T> g, int index, N width = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => generic<T>(Bits.extract(g.Data, index* natval<N>(), natval<N>()));

                 
    }
}