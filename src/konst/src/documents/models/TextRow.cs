//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    /// <summary>
    /// Defines a row of text parttioned into a sequence of cells
    /// </summary>
    public readonly struct TextRow
    {        
        public readonly TextCell[] Cells;

        [MethodImpl(Inline)]
        public TextRow(params TextCell[] cells)
        {
            Cells = cells;
        }

        public readonly string[] CellContent
        {
            [MethodImpl(Inline)]
            get => Cells.Map(x => x.Content);
        }

        [MethodImpl(Inline)]
        public void Store(Span<string> dst)
        {
            var count = Math.Min(dst.Length, Cells.Length);
            for(var i=0u; i<count; i++)
            {
                z.seek(dst,i) = Cells[i].Content;
            }
        }
        
        public string Text 
            => text.concat(CellContent);

        public int CellCount
        {
            [MethodImpl(Inline)]
            get => Cells.Length;
        }

        public ref readonly TextCell this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }

        static string ColSep(char? delimiter)
            => text.concat(Chars.Space, delimiter ?? Chars.Pipe, Chars.Space);

        /// <summary>
        /// Joins the enclosed cells to produce a line of text
        /// </summary>
        /// <param name="delimiter">The separator to apply to delimit the cell data in the line </param>
        public string Format(char? delimiter = null)
            => string.Join(ColSep(delimiter),  Cells.Select(x => x.Content));
        
        public override string ToString()
            => Format();
    }
}