//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a row of text parttioned into a sequence of cells
    /// </summary>
    public readonly struct TextRow
    {
        readonly Index<TextBlock> Blocks;

        [MethodImpl(Inline)]
        public TextRow(params TextBlock[] cells)
            => Blocks = cells;

        public readonly Index<string> CellContent
        {
            [MethodImpl(Inline)]
            get => Blocks.Map(x => x.Format());
        }

        public string RowText
            => string.Concat(CellContent);

        public int BlockCount
        {
            [MethodImpl(Inline)]
            get => Blocks.Length;
        }

        public ref readonly TextBlock this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Blocks[index];
        }

        static string ColSep(char? delimiter)
            => string.Concat(Chars.Space, delimiter ?? Chars.Pipe, Chars.Space);

        /// <summary>
        /// Joins the enclosed cells to produce a line of text
        /// </summary>
        /// <param name="delimiter">The separator to apply to delimit the cell data in the line </param>
        public string Format(char? delimiter = null)
            => string.Join(ColSep(delimiter),  Blocks.Select(x => x.Format()));

        public override string ToString()
            => Format();
    }
}