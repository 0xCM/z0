//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    
    public readonly struct TextDoc  : IReadOnlyIndex<TextRow>
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
            get => RowData.Map(r => r.Format()).Concat(text.Eol);
        }

        public Option<TextRow> Next(int index, Func<TextRow,bool> f)
        {
            for(var i=index; i<Rows.Length; i++)
            {
                var row = this[i];
                if(f(row))
                    return row;
            }
            return Option.none<TextRow>();
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
            var part = new List<TextRow>();
            for(var i=offset; i< RowCount; i++)
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
    }
}