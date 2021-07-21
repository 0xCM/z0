//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Table
    {
        readonly Index<TableRow> Data;

        readonly Index<TableColumn> _Cols;

        [MethodImpl(Inline)]
        public Table(TableColumn[] cols, TableRow[] rows)
        {
            Data = rows;
            _Cols = cols;
        }


        public Span<TableRow> Rows
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public Span<TableColumn> Cols
        {
            [MethodImpl(Inline)]
            get => _Cols.Edit;
        }

        public uint RowCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }
    }
}