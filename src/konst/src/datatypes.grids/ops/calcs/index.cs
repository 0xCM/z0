//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct GridCalcs
    {
        [MethodImpl(Inline)]
        public static GridIndex index<M,N,T>(int row, int col, M m = default, N n = default, T t =default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var rowCellCount = ScalarCast.uint16(GridCalcs.minimum<N,T>());
            var rowOffset = ScalarCast.uint32(rowCellCount*row);
            return index(
                CellIndex: ScalarCast.uint16(rowOffset + BitSize.div(col,t)),
                RowCellCount: rowCellCount,
                BitOffset: ScalarCast.uint8(BitSize.mod(col,t)),
                BitIndex: ScalarCast.uint32(rowOffset + col),
                RowIndex: row,
                ColIndex: col);
        }

        [MethodImpl(Inline), Op]
        public static GridIndex index(ushort CellIndex, ushort RowCellCount, byte BitOffset, uint BitIndex, int RowIndex, int ColIndex)
            => new GridIndex(CellIndex, RowCellCount, BitOffset, BitIndex, RowIndex, ColIndex);
    }
}