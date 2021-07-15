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
        public readonly struct Table
        {
            public TableHeader Header {get;}

            readonly Index<TableRow> _Rows;

            [MethodImpl(Inline)]
            internal Table(TableHeader header, TableRow[] rows)
            {
                Header = header;
                _Rows = rows;
            }

            public Span<TableRow> Rows
            {
                [MethodImpl(Inline)]
                get => _Rows.Edit;
            }

            public TableKind Kind
            {
                [MethodImpl(Inline)]
                get => Header.TableKind;
            }

            public uint RowCount
            {
                [MethodImpl(Inline)]
                get => _Rows.Count;
            }
        }
    }
}