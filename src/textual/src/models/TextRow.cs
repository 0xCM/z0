//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    using System.Runtime.CompilerServices;    

    using static  Seed;

    /// <summary>
    /// Defines a row of text parttioned into a sequence of cells
    /// </summary>
    public readonly struct TextRow
    {        
        public readonly TextCell[] CellData;

        public TextRow(params TextCell[] cells)
        {
            CellData = cells;
        }

        public readonly string[] TextCells
        {
            [MethodImpl(Inline)]
            get => CellData.Map(x => x.CellValue);
        }

        public void Store(Span<string> dst)
        {
            var count = Math.Min(dst.Length, CellData.Length);
            for(var i=0; i<count; i++)
            {
                refs.seek(dst,i) = CellData[i].CellValue;
            }
        }
        
        public string Text => text.concat(TextCells);

        /// <summary>
        /// The cells that comprise the row
        /// </summary>
        public ReadOnlySpan<TextCell> Cells
            => CellData;

        /// <summary>
        /// Joins the enclosed cells to produce a line of text
        /// </summary>
        /// <param name="delimiter">The separator to apply to delimit the cell data in the line </param>
        public string Format(char? delimiter = null)
            => string.Join(delimiter ?? Chars.Pipe,CellData.Select(x => x.CellValue));
        
        public override string ToString()
            => Format();
    }
}