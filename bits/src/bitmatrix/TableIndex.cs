//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Correlates a linear bit index, a cell index and bit offset, and a row/column coordinate in a grid/matrix
    /// </summary>
    public readonly struct TableIndex
    {           

        [MethodImpl(Inline)]
        public static TableIndex Define(ushort CellIndex, ushort RowCellCount, byte BitOffset, uint BitIndex, int RowIndex, int ColIndex)
            => new TableIndex(CellIndex, RowCellCount, BitOffset, BitIndex, RowIndex, ColIndex);        

        [MethodImpl(Inline)]
        TableIndex(ushort CellIndex, ushort RowCellCount, byte BitOffset, uint BitIndex, int RowIndex, int ColIndex)
        {
            this.CellIndex = CellIndex;
            this.RowCellCount = RowCellCount;
            this.BitOffset = BitOffset;
            this.RowIndex = RowIndex;
            this.ColIndex = ColIndex;
            this.BitIndex = BitIndex;
        }

        /// <summary>
        /// The container-relative index of the storage segment containing the bit
        /// </summary>
        public readonly ushort CellIndex;

        /// <summary>
        /// The number of cells covered by a row
        /// </summary>
        public readonly ushort RowCellCount;

        /// <summary>
        /// The segment-relative bit offset
        /// </summary>
        public readonly byte BitOffset;

        /// <summary>
        /// The 0-based position of the cell
        /// </summary>
        public readonly uint BitIndex;

        /// <summary>
        /// The 0-based row index
        /// </summary>
        public readonly int RowIndex;

        /// <summary>
        /// The 0-based column index
        /// </summary>
        public readonly int ColIndex;

        public string Format()
            => $"(Bit = {BitIndex}, Segment = {CellIndex}, Row = {RowIndex}, Col = {ColIndex}, Offset = {BitOffset})";
    }
}