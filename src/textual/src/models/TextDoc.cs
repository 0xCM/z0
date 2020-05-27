//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public readonly struct TextDoc
    {
        public readonly TextRow[] RowData;        

        public TextFormat Format {get;}

        public Option<TextHeader> Header {get;}
        
        public uint TotalLineCount {get;}

        public TextDoc(TextFormat format, Option<TextHeader> header,  uint count, params TextRow[] rows)
        {
            this.RowData = rows;
            this.Header = header;
            this.Format = format;
            this.TotalLineCount = count;
        }

        public ReadOnlySpan<TextRow> Rows
            => RowData;
        
        public string Content
        {
            get => RowData.Map(r => r.Format()).Concat(text.eol);
        }
        public ref readonly TextRow this[int index]
            => ref Rows[index];
        
        public uint DataLineCount
            => (uint)Rows.Length;
        
        public uint HeaderLineCount
            => Header.IsSome() ? 1u : 0u;
    }
}