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

    /// <summary>
    /// Correlates a linear bit index, a cell index and bit offset, and a row/column coordinate in a grid/matrix
    /// </summary>
    public readonly struct TableIndex
    {
        [MethodImpl(Inline)]
        public static TableIndex Create<M,N,T>(int row, int col, M m = default, N n = default, T t =default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var rowCellCount = uint16(GridCells.minimum<N,T>());
            var rowOffset = uint32(rowCellCount*row);
            return TableIndex.define(
                CellIndex: uint16(rowOffset + BitSize.div(col,t)),
                RowCellCount: rowCellCount,
                BitOffset: uint8(BitSize.mod(col,t)),
                BitIndex: uint32(rowOffset + col),
                RowIndex: row,
                ColIndex: col);
        }

        [MethodImpl(Inline)]
        public static TableIndex define(ushort CellIndex, ushort RowCellCount, byte BitOffset, uint BitIndex, int RowIndex, int ColIndex)
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
            => $"(RowCellcount = {RowCellCount}, BitIndex = {BitIndex}, CellIndex = {CellIndex}, Row = {RowIndex}, Col = {ColIndex}, BitOffset = {BitOffset})";
    }
}