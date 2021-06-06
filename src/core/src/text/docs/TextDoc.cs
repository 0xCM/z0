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

    public readonly struct TextDoc : IIndex<TextRow>
    {
        public Index<TextRow> RowData {get;}

        public TextDocFormat Format {get;}

        public TextDocHeader Header {get;}

        public uint LineCount {get;}

        [MethodImpl(Inline)]
        public TextDoc(TextDocFormat format, TextDocHeader header, uint count, params TextRow[] rows)
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
            get => Header.IsNonEmpty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => LineCount == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => LineCount != 0;
        }

        public static TextDoc Empty
            => new TextDoc(TextDocFormat.Empty, default, 0, sys.empty<TextRow>());
    }
}