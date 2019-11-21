//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitGrid
    {
        /// <summary>
        /// Loads a generic bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="map">The grid map</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> load<T>(Span<T> src, ushort rows, ushort cols)
            where T : unmanaged
                => new BitGrid<T>(src, rows, cols);

        /// <summary>
        /// Loads a natural bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="zero">The storage representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> load<M,N,T>(Span<T> src, M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var layout = map(m,n,zero);
            require(src.Length == layout.SegCount);
            return new BitGrid<M, N, T>(src);
        }

        /// <summary>
        /// Loads a natural bitgrid of dimensions Mx8 of type byte from primal bitvectors of length 8
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="M">The row count type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N8,byte> load<M>(M m, Span<BitVector8> src)
            where M : unmanaged, ITypeNat
                => new BitGrid<M,N8,byte>(src.AsBytes());

        /// <summary>
        /// Loads a natural bitgrid of dimensions Mx16 of type ushort from primal bitvectors of length 16
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="M">The row count type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N16,ushort> load<M>(M m, Span<BitVector16> src)
            where M : unmanaged, ITypeNat
                => new BitGrid<M,N16,ushort>(src.AsUInt16());

        /// <summary>
        /// Loads a natural bitgrid of dimensions Mx32 of type uint from primal bitvectors of length 32
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="M">The row count type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N32,uint> load<M>(M m, Span<BitVector32> src)
            where M : unmanaged, ITypeNat
                => new BitGrid<M,N32,uint>(src.AsUInt32());

        /// <summary>
        /// Loads a natural bitmatrix of dimensions Mx64 of type ulong from primal bitvectors of length 64
        /// </summary>
        /// <param name="m">The row count</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="M">The row count type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N64,ulong> load<M>(M m, Span<BitVector64> src)
            where M : unmanaged, ITypeNat
                => new BitGrid<M,N64,ulong>(src.AsUInt64());


    }

}