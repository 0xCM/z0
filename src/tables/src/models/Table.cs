//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Table
    {
        readonly Index<TableRow> Data;

        [MethodImpl(Inline)]
        public Table(TableRow[] rows)
        {
            Data = rows;
        }

        public Span<TableRow> Rows
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint RowCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}