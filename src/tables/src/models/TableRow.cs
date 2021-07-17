//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct TableRow
    {
        internal uint _Seq;

        readonly Index<TableCell> _Cells;

        [MethodImpl(Inline)]
        public TableRow(uint index, TableCell[] cells)
        {
            _Seq = index;
            _Cells = cells;
        }

        public uint Sequence
        {
            [MethodImpl(Inline)]
            get => _Seq;
        }

        public Span<TableCell> Cells
        {
            [MethodImpl(Inline)]
            get => _Cells.Edit;
        }
    }
}