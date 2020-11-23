//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.GridMetrics, true)]
    public readonly struct GridMetrics
    {
        /// <summary>
        /// Determines whether grid storage is N-bit aligned
        /// </summary>
        /// <param name="src">The source specifier</param>
        /// <param name="w">A width-type representative</param>
        /// <typeparam name="N">The bit type</typeparam>
        [MethodImpl(Inline), Op]
        public static bool aligned<N>(in GridMetrics src, N n = default)
            where N : unmanaged, ITypeNat
                => (ulong)src.StoreSize % TypeNats.value(n) == 0;

        /// <summary>
        /// Determines whether grid storage is data width-aligned
        /// </summary>
        /// <param name="src">The source specifier</param>
        /// <param name="w">A width-type representative</param>
        [MethodImpl(Inline), Op]
        public static bool aligned(in GridMetrics src, DataWidth w)
            => src.StoreSize % (uint)w == 0;

        /// <summary>
        /// Determines whether grid storage is aligned with that of a specified numeric kind
        /// </summary>
        /// <param name="src">The source specifier</param>
        /// <param name="w">A width-type representative</param>
        /// <typeparam name="W">The bit-width type</typeparam>
        [MethodImpl(Inline), Op]
        public static bool aligned(in GridMetrics src, NumericKind k)
            => src.StoreSize % k.Width() == 0;

        [MethodImpl(Inline), Op]
        public static uint remainder(in GridMetrics src, W128 w)
            => src.StoreSize % 16;

        [MethodImpl(Inline), Op]
        public static uint coverage(in GridMetrics src, W128 w)
        {
            var r = remainder(src,w);
            return r != 0 ? r + 1 : r;
        }

        [MethodImpl(Inline), Op]
        public static uint remainder(in GridMetrics src, W256 w)
            => src.StoreSize % 32;

        [MethodImpl(Inline), Op]
        public static uint coverage(in GridMetrics src, W256 w)
        {
            var r = remainder(src,w);
            return r != 0 ? r + 1 : r;
        }

        [MethodImpl(Inline), Op]
        public static uint points(in GridMetrics src)
            => (uint)(src.RowCount*src.ColCount);

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static int linear(in GridMetrics src, int row, int col)
            => GridCells.linear(src.ColCount, row, col);

        /// <summary>
        /// Computes the storage segment offset for a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static int offset(in GridMetrics src, int row, int col)
            => linear(src, row,col) % src.CellWidth;

        /// <summary>
        /// Computes the storage segment that covers a specified row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static int seg(in GridMetrics src, int row, int col)
            => linear(src,row,col) / src.CellWidth;

        /// <summary>
        /// The number of rows in the layout
        /// </summary>
        public readonly ushort RowCount;

        /// <summary>
        /// The number of columns in the layout
        /// </summary>
        public readonly ushort ColCount;

        /// <summary>
        /// The number of bits in a segment
        /// </summary>
        public readonly ushort CellWidth;

        /// <summary>
        /// The number of segment-aligned storage segments
        /// </summary>
        public readonly uint CellCount;

        /// <summary>
        /// The number of segment-aligned bits required for storage
        /// </summary>
        public readonly uint StoreWidth;

        /// <summary>
        /// The number of segment-aligned bytes bits required for storage
        /// </summary>
        public readonly uint StoreSize;

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline)]
        public int Position(int row, int col)
            => linear(this,row,col);

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        public int this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => Position(row,col);
        }

        [MethodImpl(Inline)]
        public GridMetrics(in GridSpec spec)
        {
            RowCount = spec.RowCount;
            ColCount = spec.ColCount;
            CellWidth = spec.CellWidth;
            StoreWidth = spec.StoreWidth;
            StoreSize = spec.StoreSize;
            CellCount = spec.CellCount;
        }
    }
}