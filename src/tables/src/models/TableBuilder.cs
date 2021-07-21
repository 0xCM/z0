//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public class TableBuilder
    {
        List<TableRow> Rows;

        TableColumn[] Cols;

        public static TableBuilder create()
            => new TableBuilder();

        public TableBuilder()
        {
            Rows = new();
            Cols = array<TableColumn>();
        }

        public TableBuilder WithRow(in TableRow row)
        {
            Rows.Add(row);
            return this;
        }

        public TableBuilder WithColumns(TableColumn[] cols)
        {
            Cols = cols;
            return this;
        }

        public TableBuilder WithRow(TableCell[] cells)
        {
            Rows.Add(new TableRow(0,cells));
            return this;
        }

        public TableBuilder WithRow(string[] cells)
        {
            Rows.Add(new TableRow(0,cells.Select(x => new TableCell(x))));
            return this;
        }

        public TableBuilder WithRows(ReadOnlySpan<TableRow> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Rows.Add(core.skip(src,i));
            return this;
        }

        public TableBuilder IfNonEmpty(Action f)
        {
            if(IsNonEmpty)
                f();
            return this;
        }

        public Table Emit()
        {
            var rows = Rows.ToArray();
            var count = rows.Length;
            ref var row = ref first(rows);
            for(var i=0u; i<count; i++)
                seek(row,i)._Seq = i;
            var dst = new Table(Cols, rows);
            Clear();
            return dst;
        }

        public TableBuilder Clear()
        {
            Rows.Clear();
            return this;
        }

        public bool IsNonEmpty
        {
            get => Rows.Count != 0;
        }
    }
}