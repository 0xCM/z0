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
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector8 col<T>(in BitGrid32<N8,N4,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, BitMask.Lsb32x8 << index);            

        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector8 col<T>(in BitGrid64<N8,N8,T> g, int index)
            where T : unmanaged
                => (byte)Bits.gather(g, BitMask.Lsb64x8 << index);            

        /// <summary>
        /// Extracts an index-identifed 8-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, either 0 or 1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector32 col<T>(in BitGrid64<N32,N2,T> g, int index)
            where T : unmanaged
                => (uint)Bits.gather(g, BitMask.Lsb64x32 << index);            

        /// <summary>
        /// Extracts an index-identifed 16-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector16 col<T>(in BitGrid128<N16,N8,T> g, int index)
            where T : unmanaged
                => (ushort)ginx.vmovemask(ginx.vsll(g.Data, (byte)(7 - index)));

        /// <summary>
        /// Extracts an index-identifed 32-bit grid column
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector32 col<T>(in BitGrid256<N32,N8,T> g, int index)
            where T : unmanaged
                => ginx.vmovemask(ginx.vsll(g.Data, (byte)(7 - index)));

    }
}