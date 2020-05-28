//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct TextDoc
    {
        public readonly TextRow[] RowData;        

        public TextFormat Format {get;}

        public Option<TextHeader> Header {get;}
        
        public uint TotalLineCount {get;}

        [MethodImpl(Inline)]
        public TextDoc(TextFormat format, Option<TextHeader> header,  uint count, params TextRow[] rows)
        {
            this.RowData = rows;
            this.Header = header;
            this.Format = format;
            this.TotalLineCount = count;
        }

        public ReadOnlySpan<TextRow> Rows
        {
            [MethodImpl(Inline)]
            get => RowData;
        }
        
        public string Content
        {
            get => RowData.Map(r => r.Format()).Concat(text.eol);
        }

        public ref readonly TextRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }
        
        public int RowCount
        {
            [MethodImpl(Inline)]
            get => Rows.Length;
        }
        
        public bool HasHeader
        {
            [MethodImpl(Inline)]
            get => Header.IsSome();
        }
    }
}