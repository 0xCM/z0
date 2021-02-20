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
    /// Represents a line of text in the context of a line-oriented text data source
    /// </summary>
    public readonly struct TextLine
    {
        /// <summary>
        /// The line number of the data source from which the line was extracted
        /// </summary>
        public uint LineNumber {get;}

        /// <summary>
        /// The line text, as it was found in the source
        /// </summary>
        public string Content {get;}

        [MethodImpl(Inline)]
        public TextLine(uint number, string text)
        {
            LineNumber = number;
            Content = text ?? EmptyString;
        }

        [MethodImpl(Inline)]
        public TextLine(int number, string text)
        {
            LineNumber = (uint)number;
            Content = text ?? EmptyString;
        }

        public char this[int charidx]
        {
            [MethodImpl(Inline)]
            get => Content[charidx];
        }

        [MethodImpl(Inline)]
        public TextBlock Segment(uint i0, uint i1)
            => text.segment(Content, i0, i1);

        [MethodImpl(Inline)]
        public TextBlock Slice(uint offset, uint length)
            => text.slice(Content, offset, length);

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

        [MethodImpl(Inline)]
        public bool StartsWith(char match)
            => IsNonEmpty && Content[0] == match;

        [MethodImpl(Inline)]
        public bool StartsWith(string match)
            => IsNonEmpty && Content.StartsWith(match);

        public string[] Split(in TextDocFormat spec)
            => IsNonEmpty
            ? spec.SplitClean ? Content.SplitClean(spec.Delimiter) : Content.Split(spec.Delimiter)
            : sys.empty<string>();

        public string Format()
            => $"{LineNumber.ToString().PadLeft(8, '0')}:{Content}";

        public override string ToString()
            => Format();

        public string this[int startpos, int endpos]
            => Content.Substring(startpos, endpos - startpos + 1);

        [MethodImpl(Inline)]
        public static implicit operator TextLine((int index, string text) src)
            =>  new TextLine(src.index, src.text);

        [MethodImpl(Inline)]
        public static implicit operator TextLine((uint index, string text) src)
            =>  new TextLine(src.index, src.text);

        public static TextLine Empty
            => new TextLine(0, EmptyString);
    }
}