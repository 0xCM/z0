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

    partial class BitGrid
    {        
        /// <summary>
        /// Extracts an index-identifed 1-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit row<M,T>(BitGrid16<M,N1,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => Bits.extract(g, index*1, 1) == 1;

        /// <summary>
        /// Extracts an index-identifed 4-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> row<M,T>(BitGrid16<N4,N4,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => (byte)Bits.extract(g, index*2, 4);

        /// <summary>
        /// Extracts an index-identifed 1-bit grid row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...31</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit row<M,T>(BitGrid32<M,N1,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => Bits.extract(g, index*1, 1) == 1;

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> row<M,T>(BitGrid32<M,N2,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => (byte)Bits.extract(g, index*2, 2);

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> row<M,T>(BitGrid32<M,N4,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => (byte)Bits.extract(g, index*4, 4);

        /// <summary>
        /// Extracts an index-identifed 8-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...3</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<byte> row<M,T>(BitGrid32<M,N8,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => (byte)Bits.extract(g, index*8, 8);

        /// <summary>
        /// Extracts an index-identifed 16-bit row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ushort> row<M,T>(BitGrid32<M,N16,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => (ushort)Bits.extract(g, index*16, 16);

        /// <summary>
        /// Presents grid content as a bitvector
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> row<M,T>(BitGrid32<M,N32,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => g.Data;

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit row<M,T>(BitGrid64<M,N1,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => Bits.extract(g, index*1, 1) == 1;

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N2,byte> row<M,T>(BitGrid64<M,N2,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            => (byte)Bits.extract(g, index*2, 2);

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> row<M,T>(BitGrid64<M,N4,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            => (byte)Bits.extract(g, index*4, 4);

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> row<M,T>(BitGrid64<M,N8,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => (byte)Bits.extract(g,index*8, 8);

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...3</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> row<M,T>(BitGrid64<M,N16,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => (ushort)Bits.extract(g,index*16, 16);

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> row<M,T>(BitGrid64<M,N32,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => (uint)Bits.extract(g, index*32,32);

        /// <summary>
        /// Presents grid content as a bitvector
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> row<M,T>(BitGrid64<M,N64,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
                => g.Data;

        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> row<T>(in BitGrid256<N16,N16,T> g, int index)
            where T : unmanaged
                => v16u(g.data).GetElement(index);
    }
}