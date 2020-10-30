//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct GridSegment<T> : ITextual
        where T : unmanaged
    {
        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public readonly ushort RowCount;

        /// <summary>
        /// The number of columns in the grid
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
        public GridSegment(ushort rows, ushort cols, ushort segwidth)
        {
            RowCount = rows;
            ColCount = cols;
            SegWidth = segwidth;
            CellWidth = (ushort)bitwidth<T>();
        }

        /// <summary>
        /// Returns a dimension expression of the form RxCxWw where
        /// R := row count
        /// C := column count
        /// W := cell width
        /// </summary>
        public string Format()
            => $"{RowCount}x{ColCount}x{CellWidth}w";
    }
}