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
        /// Extracts an index-identifed 2-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit col<N,T>(BitGrid32<N1,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Bits.gather(g, BitMask.Lsb32x1 << index) == 1;            

        /// <summary>
        /// Extracts an index-identifed 2-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector4 col<N,T>(BitGrid32<N2,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (byte)Bits.gather(g, BitMask.Lsb32x2 << index);            

        /// <summary>
        /// Extracts an index-identifed 4-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector4 col<N,T>(BitGrid32<N4,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (byte)Bits.gather(g, BitMask.Lsb32x4 << index);            

        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<byte> col<N,T>(BitGrid32<N8,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (byte)Bits.gather(g, BitMask.Lsb32x8 << index);            

        /// <summary>
        /// Extracts an index-identifed 16-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ushort> col<N,T>(BitGrid32<N16,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (ushort)Bits.gather(g, BitMask.Lsb32x16 << index);            

        /// <summary>
        /// Presents grid content as a bitvector
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<uint> col<N,T>(BitGrid32<N32,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => g.Scalar;

        /// <summary>
        /// Extracts an index-identifed 2-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static bit col<N,T>(BitGrid64<N1,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Bits.gather(g, BitMask.Lsb64x1 << index) == 1;            

        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector4 col<N,T>(BitGrid64<N2,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (byte)Bits.gather(g, BitMask.Lsb64x2 << index);            

        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector4 col<N,T>(BitGrid64<N4,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (byte)Bits.gather(g, BitMask.Lsb64x4 << index);            

        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<byte> col<N,T>(BitGrid64<N8,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (byte)Bits.gather(g, BitMask.Lsb64x8 << index);            

        /// <summary>
        /// Extracts an index-identifed 16-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ushort> col<N,T>(BitGrid64<N16,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (ushort)Bits.gather(g, BitMask.Lsb64x16 << index);            

        /// <summary>
        /// Extracts an index-identifed 32-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<uint> col<N,T>(BitGrid64<N32,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => (uint)Bits.gather(g, BitMask.Lsb64x32 << index);            

        /// <summary>
        /// Presents grid content as a bitvector
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ulong> col<N,T>(BitGrid64<N64,N,T> g, int index)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => g.Scalar;

        // [MethodImpl(Inline)]
        // public static BitVector16 col<N,T>(BitGrid64<N16,N,T> g, int index)
        //     where T : unmanaged
        //     where N : unmanaged, ITypeNat
        // {
        //     // C0 = [0001 0001 ... 0001]
        //     // C1 = C0 << 1 = [0010 0010 ... 0010]
        //     // C2 = C0 << 2 = [0100 0100 ... 0100]
        //     // C3 = C0 << 3 = [1000 1000 ... 1000]
        //     const ulong C0 = 
        //         (1ul << 64 - 1*4) | (1ul << 64 - 2*4) | (1ul << 64 - 3*4) | (1ul << 64 - 4*4) | 
        //         (1ul << 64 - 5*4) | (1ul << 64 - 6*4) | (1ul << 64 - 7*4) | (1ul << 64 - 8*4) |
        //         (1ul << 64 - 9*4) | (1ul << 64 - A*4) | (1ul << 64 - B*4) | (1ul << 64 - C*4) |
        //         (1ul << 64 - D*4) | (1ul << 64 - E*4) | (1ul << 64 - F*4) | 1;        
        //     return (ushort)Bits.gather(g, C0 << index);
        // }


        /// <summary>
        /// Extracts an index-identifed 16-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<ushort> col<T>(in BitGrid128<N16,N8,T> g, int index)
            where T : unmanaged
                => (ushort)ginx.vmovemask(ginx.vsll(g.Data, (byte)(7 - index)));

        /// <summary>
        /// Extracts an index-identifed 32-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<uint> col<T>(in BitGrid256<N32,N8,T> g, int index)
            where T : unmanaged
                => ginx.vmovemask(ginx.vsll(g.Data, (byte)(7 - index)));

    }
}