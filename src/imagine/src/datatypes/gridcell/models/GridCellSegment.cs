//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    using static Root;

    public readonly struct GridCellSegment<T> : IGridDim<T>, ITextual
        where T : unmanaged
    {
        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public readonly ushort RowCount;

        /// <summary>
        /// The number of columsn in the grid
        /// </summary>
        public readonly ushort ColCount;

        /// <summary>
        /// The bit-width of a grid cell
        /// </summary>
        public readonly ushort CellWidth;

        /// <summary>
        /// The bit-width of a segment that covers one or more cells
        /// </summary>
        public readonly ushort SegWidth;

        [MethodImpl(Inline)]
        public GridCellSegment(ushort rows, ushort cols, ushort segwidth)
        {
            RowCount = rows;
            ColCount = cols;
            CellWidth = (ushort)bitsize<T>();
            SegWidth = segwidth;
        }

        /// <summary>
        /// Returns a dimension expression of the form RxCxWw where 
        /// R := row count
        /// C := column count
        /// W := cell width
        /// </summary>
        public string Format()
            => $"{RowCount}x{ColCount}x{CellWidth}w";

        int IGridDim.RowCount 
        {
            [MethodImpl(Inline)]
            get => RowCount;
        }

        int IGridDim.ColCount 
        {
            [MethodImpl(Inline)]
            get => ColCount;
        }
    }
}