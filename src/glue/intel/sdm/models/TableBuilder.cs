//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    partial struct IntelSdm
    {
        public class TableBuilder
        {
            TableHeader Header;

            List<TableRow> Rows;

            public static TableBuilder create()
                => new TableBuilder();

            public TableBuilder()
            {
                Rows = new();
                Header = TableHeader.Empty;
            }

            public TableBuilder WithHeader(in TableHeader src)
            {
                Header = src;
                return this;
            }

            public TableBuilder WithRow(in TableRow row)
            {
                Rows.Add(row);
                return this;
            }

            public TableBuilder WithRow(TableCell[] cells)
            {
                Rows.Add(row(cells));
                return this;
            }

            public TableBuilder WithRow(string[] cells)
            {
                Rows.Add(row(cells));
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
                var dst = table(Header, rows);
                Clear();
                return dst;
            }

            public TableBuilder Clear()
            {
                Rows.Clear();
                Header = TableHeader.Empty;
                return this;
            }

            public bool IsNonEmpty
            {
                get => Rows.Count != 0;
            }
        }
    }
}