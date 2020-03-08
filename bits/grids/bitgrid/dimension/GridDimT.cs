//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct GridDim<T> : IGridDim<T>, IFormattable<GridDim<T>>
        where T : unmanaged
    {
        public GridDim(int rows, int cols, int? blockwidth = null)
        {
            this.RowCount = rows;
            this.ColCount = cols;
            this.CellWidth = bitsize<T>();
            this.BlockWidth = blockwidth ?? CellWidth;
        }

        /// <summary>
        /// The number of rows in the grid
        /// </summary>
        public int RowCount {get;}

        /// <summary>
        /// The number of columsn in the grid
        /// </summary>
        public int ColCount {get;}

        /// <summary>
        /// The bit-width of a grid cell
        /// </summary>
        public int CellWidth {get;}

        /// <summary>
        /// The block width, set to 1 if the grid is unblocked
        /// </summary>
        public int BlockWidth {get;}

        /// <summary>
        /// The total number gb of grid bits determined by gb := MxN
        /// </summary>
        public int BitCount
        {
            [MethodImpl(Inline)]
            get => RowCount * ColCount;
        }

        /// <summary>
        /// The number of cells required cover a grid
        /// </summary>
        public int CellCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.tablecells<T>(RowCount,ColCount);
        }

        /// <summary>
        /// The number of bytes required to cover a grid
        /// </summary>
        public int ByteCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.tablesize(RowCount, ColCount);
        }

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline)]
        public int Pos(int row, int col)
            => BitCalcs.bitindex(ColCount, row, col);

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