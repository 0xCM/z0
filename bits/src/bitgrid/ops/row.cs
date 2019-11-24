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
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector4 row<T>(in BitGrid32<N8,N4,T> g, int index)
            where T : unmanaged
        {
            const uint mask = 0b1111u;
            const int width = 4;
            return (byte)((g.Scalar >> index*width) & mask);
        }

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...15</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector4 row<T>(in BitGrid64<N16,N4,T> g, int index)
            where T : unmanaged
        {
            const ulong mask = 0b1111u;
            const int width = 4;
            return (byte)((g.Scalar >> index*width) & mask);
        }

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...3</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector16 row<T>(in BitGrid64<N4,N16,T> g, int index)
            where T : unmanaged
        {
            const ulong mask = ushort.MaxValue;
            const int width = 16;
            return (ushort)((g.Scalar >> index*width) & mask);
        }

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based row index, in the inclusive range 0...1</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector32 row<T>(in BitGrid64<N2,N32,T> g, int index)
            where T : unmanaged
        {
            const ulong mask = uint.MaxValue;
            const int width = 32;
            return (uint)((g.Scalar >> index*width) & mask);
        }

        /// <summary>
        /// Extracts an index-identifed row
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The zero-based column index, in the inclusive range 0...7</param>
        /// <typeparam name="T">The grid cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector8 row<T>(in BitGrid64<N8,N8,T> g, int index)
            where T : unmanaged
        {
            const ulong mask = 0b11111111u;
            const int width = 8;
            return (byte)((g.Scalar >> index*width) & mask);
        }

        [MethodImpl(Inline)]
        public static BitVector16 row<T>(in BitGrid256<N16,N16,T> g, int index)
            where T : unmanaged
                => v16u(g.Data).GetElement(index);

    }
}