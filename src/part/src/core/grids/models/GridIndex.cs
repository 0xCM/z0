//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Correlates a linear bit index, a cell index and bit offset, and a row/column coordinate in a grid/matrix
    /// </summary>
    public struct GridIndex
    {
        /// <summary>
        /// The container-relative index of the storage segment containing the bit
        /// </summary>
        public ushort CellIndex {get;}

        /// <summary>
        /// The number of cells covered by a row
        /// </summary>
        public ushort RowCellCount {get;}

        /// <summary>
        /// The segment-relative bit offset
        /// </summary>
        public byte BitOffset;

        /// <summary>
        /// The 0-based position of the cell
        /// </summary>
        public uint BitIndex;

        /// <summary>
        /// The 0-based row index
        /// </summary>
        public int RowIndex;

        /// <summary>
        /// The 0-based column index
        /// </summary>
        public int ColIndex;

        [MethodImpl(Inline)]
        public GridIndex(ushort CellIndex, ushort RowCellCount, byte BitOffset, uint BitIndex, int RowIndex, int ColIndex)
        {
            this.CellIndex = CellIndex;
            this.RowCellCount = RowCellCount;
            this.BitOffset = BitOffset;
            this.RowIndex = RowIndex;
            this.ColIndex = ColIndex;
            this.BitIndex = BitIndex;
        }

        public string Format()
            => $"(RowCellcount = {RowCellCount}, BitIndex = {BitIndex}, CellIndex = {CellIndex}, Row = {RowIndex}, Col = {ColIndex}, BitOffset = {BitOffset})";
    }
}