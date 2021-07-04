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
        public readonly struct TableCell
        {
            public TableKind TableKind {get;}

            public ColumnKind ColKind {get;}

            public ushort RowIndex {get;}

            public ushort ColIndex {get;}

            public string Content {get;}

            [MethodImpl(Inline)]
            public TableCell(TableKind table, ColumnKind colkind, ushort rowidx, ushort colidx, string content)
            {
                TableKind = table;
                ColKind = colkind;
                RowIndex = rowidx;
                ColIndex = colidx;
                Content = content;
            }
        }
    }
}