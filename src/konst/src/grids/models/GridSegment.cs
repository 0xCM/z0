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
        public ushort RowCount {get;}

        /// <summary>
        /// The number of columns in the grid
        /// </summary>
        public ushort ColCount {get;}

        /// <summary>
        /// The bit-width of a grid cell
        /// </summary>
        public ushort CellWidth {get;}

        /// <summary>
        /// The bit-width of a segment that covers one or more cells
        /// </summary>
        public ushort SegWidth {get;}

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