//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public readonly struct TextDoc : IIndex<TextRow>
    {
        public Index<TextRow> RowData {get;}

        public TextDocFormat Format {get;}

        public Option<TextDocHeader> Header {get;}

        public uint LineCount {get;}

        [MethodImpl(Inline)]
        public TextDoc(TextDocFormat format, Option<TextDocHeader> header, uint count, params TextRow[] rows)
        {
            RowData = rows;
            Header = header;
            Format = format;
            LineCount = count;
        }

        public ReadOnlySpan<TextRow> Rows
        {
            [MethodImpl(Inline)]
            get => RowData.View;
        }

        public TextRow[] Storage
        {
            [MethodImpl(Inline)]
            get => RowData.Storage;
        }

        public string Content
        {
            [MethodImpl(Inline)]
            get => RowData.Map(r => r.Format()).Join(Eol);
        }

        public ref readonly TextRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref RowData[index];
        }

        public int RowCount
        {
            [MethodImpl(Inline)]
            get => Rows.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Rows.Length;
        }

        public bool HasHeader
        {
            [MethodImpl(Inline)]
            get => Header.IsSome();
        }

        public IEnumerable<TextRows> Partition(int offset, Func<TextRow,bool> f)
        {
            var part = root.list<TextRow>();
            for(var i=offset; i<RowCount; i++)
            {
                var row = this[i];
                if(f(row))
                {
                    yield return new TextRows(part.ToArray());
                    part.Clear();
                }
                else
                    part.Add(row);
            }
        }

        public void Parse<T>(Span<T> dst, Func<TextRow,T> parser)
        {
            var rows = RowData.View;
            var count = rows.Length;
            for(var i=0; i<count; i++)
               seek(dst,i) = parser(skip(rows,i));
        }

        public static TextDoc Empty
            => new TextDoc(TextDocFormat.Empty, default, 0, sys.empty<TextRow>());
    }
}