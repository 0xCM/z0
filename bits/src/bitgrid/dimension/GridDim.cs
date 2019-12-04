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

    /// <summary>
    /// Defines grid dimensions based on specification without parametrization
    /// </summary>
    public readonly struct GridDim : IGridDim
    {
        public GridDim(int rows, int cols, int cellwidth, int? blockwidth = null)
        {
            this.RowCount = rows;
            this.ColCount = cols;
            this.CellWidth = cellwidth;
            this.BlockWidth = blockwidth ?? CellWidth;
        }

        /// <summary>
        /// The number of grid rows
        /// </summary>
        public int RowCount {get;}

        /// <summary>
        /// The number of grid columns
        /// </summary>
        public int ColCount {get;}

        /// <summary>
        /// The bit width of a storage cell
        /// </summary>
        public int CellWidth {get;}

        /// <summary>
        /// The bit width of a storage block
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
            get => BitCalcs.cellcount(RowCount,ColCount, CellWidth);
        }

        /// <summary>
        /// The number of bytes required to cover a grid
        /// </summary>
        public int ByteCount
        {
            [MethodImpl(Inline)]
            get => BitCalcs.bytecount(RowCount, ColCount);
        }

        /// <summary>
        /// A semantic identifier that characterizes/identifies a grid
        /// </summary>
        public GridMoniker Moniker 
        {
            [MethodImpl(Inline)]
            get => GridMoniker.FromSpecs(RowCount,ColCount,CellWidth);
        }

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline)]
        public int Pos(int row, int col)
            => BitCalcs.bitpos(ColCount, row, col);

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