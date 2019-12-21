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
        /// Extracts an index-identifed 1-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit col<T>(BitGrid16<N1,N16,T> g, int index)
            where T : unmanaged
                => (bit)(g.Data & (BitMasks.Lsb16 << index));

        /// <summary>
        /// Extracts an index-identifed 2-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N2,byte> col<T>(BitGrid16<N2,N8,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, (uint)(BitMasks.Lsb16x8 << index));            
                
        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> col<T>(BitGrid16<N8,N2,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, (uint)(BitMasks.Lsb16x2 << index));            

        /// <summary>
        /// Extracts an index-identifed 4-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...3</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> col<T>(BitGrid16<N4,N4,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, (uint)(BitMasks.Lsb16x4 << index));            

        /// <summary>
        /// Extracts an index-identifed 1-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit col<T>(BitGrid32<N1,N32,T> g, int index)
            where T : unmanaged
                => Bits.gather(g, BitMasks.Lsb32 << index) == 1;            

        /// <summary>
        /// Extracts an index-identifed 2-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N2,byte> col<T>(BitGrid32<N2,N16,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, BitMasks.Lsb32x16 << index);            

        /// <summary>
        /// Extracts an index-identifed 4-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> col<T>(BitGrid32<N4,N8,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, BitMasks.Lsb32x8 << index);            

        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> col<T>(BitGrid32<N8,N4,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, BitMasks.Lsb32x4 << index);            

        /// <summary>
        /// Extracts an index-identifed 16-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> col<T>(BitGrid32<N16,N2,T> g, int index)
            where T : unmanaged
                => (ushort)Bits.gather(g, BitMasks.Lsb32x2 << index);            

        /// <summary>
        /// Extracts an index-identifed 1-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit col<T>(BitGrid64<N1,N64,T> g, int index)
            where T : unmanaged
                => Bits.gather(g, BitMasks.Lsb64 << index) == 1;            

        /// <summary>
        /// Extracts an index-identifed 2-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...31</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N2,byte> col<T>(BitGrid64<N2,N32,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, BitMasks.Lsb64x32 << index);            

        /// <summary>
        /// Extracts an index-identifed 4-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N4,byte> col<T>(BitGrid64<N4,N16,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, BitMasks.Lsb64x16 << index);            

        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N8,byte> col<T>(BitGrid64<N8,N8,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, BitMasks.Lsb64x8 << index);            

        /// <summary>
        /// Extracts an index-identifed 16-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...3</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> col<T>(BitGrid64<N16,N4,T> g, int index)
            where T : unmanaged
                => (ushort)Bits.gather(g, BitMasks.Lsb64x4<< index);            

        /// <summary>
        /// Extracts an index-identifed 32-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> col<T>(BitGrid64<N32,N2,T> g, int index)
            where T : unmanaged
                => (uint)Bits.gather(g, BitMasks.Lsb64x2 << index);            

        /// <summary>
        /// Presents grid content as a bitvector
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N64,ulong> col<T>(BitGrid64<N64,N1,T> g, int index)
            where T : unmanaged
                => g.Data;

        /// <summary>
        /// Extracts an index-identifed 16-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N16,ushort> col<T>(in BitGrid128<N16,N8,T> g, int index)
            where T : unmanaged
                => ginx.vtakemask(ginx.vsll(g.Data, (byte)(7 - index)));

        /// <summary>
        /// Extracts an index-identifed 32-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N32,uint> col<T>(in BitGrid256<N32,N8,T> g, int index)
            where T : unmanaged
                => ginx.vtakemask(ginx.vsll(g.Data, (byte)(7 - index)));

        [MethodImpl(Inline)]
        public static int colidx<N>(N width, int row, int col)
            where N : unmanaged, ITypeNat
                => natval(width) * row + col;        
    }
}