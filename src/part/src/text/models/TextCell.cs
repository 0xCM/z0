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
    /// Defines a text segment in the context of a line in a file
    /// </summary>
    public readonly struct TextCell
    {
        public uint Row {get;}

        public uint Col {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public TextCell(uint row, uint col, string content)
        {
            Row = row;
            Col = col;
            Content = content;
        }

        public char this[int index]
        {
            [MethodImpl(Inline)]
            get => Content[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator string(TextCell src)
            => src.Content;
    }
}