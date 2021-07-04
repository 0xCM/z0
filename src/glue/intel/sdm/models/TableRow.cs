//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        public readonly struct TableRow
        {
            public TableKind TableKind {get;}

            public ushort Index {get;}

            readonly Index<TableCell> _Cells;

            [MethodImpl(Inline)]
            internal TableRow(TableKind table, ushort index, TableCell[] cells)
            {
                TableKind = table;
                Index = index;
                _Cells = cells;
            }

            public Span<TableCell> Cells
            {
                [MethodImpl(Inline)]
                get => _Cells.Edit;
            }
        }
    }
}