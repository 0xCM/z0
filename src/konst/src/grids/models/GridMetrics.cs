//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct GridMetrics
    {
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
            => GridCalcs.linear(this, row, col);

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