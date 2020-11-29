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
    /// Represents a line of text in the context of a line-oriented text data source
    /// </summary>
    public readonly struct TextDocLine
    {
        /// <summary>
        /// The line number of the data source from which the line was extracted
        /// </summary>
        public uint Index {get;}

        /// <summary>
        /// The line text, as it was found in the source
        /// </summary>
        public string Content {get;}

        [MethodImpl(Inline)]
        public TextDocLine(uint number, string text)
        {
            Index = number;
            Content = text ?? EmptyString;
        }

        public char this[int charidx]
        {
            [MethodImpl(Inline)]
            get => Content[charidx];
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Content);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.blank(Content);
        }

        public string[] Split(in TextDocFormat spec)
            => IsNonEmpty ? Content.SplitClean(spec.Delimiter) : sys.empty<string>();

        public override string ToString()
            =>  $"{Index.ToString().PadLeft(10, '0')}:{Content}";

        public string this[int startpos, int endpos]
            => Content.Substring(startpos, endpos - startpos + 1);

        [MethodImpl(Inline)]
        public static explicit operator TextDocLine(string text)
            =>  new TextDocLine(0, text);

        [MethodImpl(Inline)]
        public static implicit operator string(TextDocLine line)
            => line.Content;

        public static TextDocLine Empty
            => new TextDocLine(0, EmptyString);
    }
}