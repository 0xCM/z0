//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        [MethodImpl(Inline)]
        static string substring(string src, int startidx)
            => src?.Substring(startidx) ?? EmptyString;

        [MethodImpl(Inline)]
        static string substring(string src, int startidx, int len)
            => src?.Substring(startidx, len) ?? EmptyString;
        [Op]
        static string segment(string src, int i0, int i1)
        {
            var length = i1 - i0 + 1;
            if(length < 0  || length - i0 > src.Length)
                new Exception($"Cannot select the segment [{i0},{i1}] from the source string {src}");
            return substring(src, i0, length);
        }

        [MethodImpl(Inline)]
        static string segment(string src, uint i0, uint i1)
            => segment(src, (int)i0, (int)i1);

        [MethodImpl(Inline)]
        static string slice(string src, uint offset, uint length)
            => substring(src,(int)offset, (int)length);

        [MethodImpl(Inline)]
        public TextBlock Segment(uint i0, uint i1)
            => segment(Content, i0, i1);

        [MethodImpl(Inline)]
        public TextBlock Slice(uint offset, uint length)
            => slice(Content, offset, length);

        public TextBlock Trim()
            => IsNonEmpty ? Content.Trim() : TextBlock.Empty;

        [MethodImpl(Inline)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => nonempty(Content);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Content);
        }

        [MethodImpl(Inline)]
        public bool StartsWith(char match)
            => IsNonEmpty && Content[0] == match;

        [MethodImpl(Inline)]
        public bool StartsWith(string match)
            => IsNonEmpty && Content.StartsWith(match);

        public ReadOnlySpan<string> Split(in TextDocFormat spec)
            => IsNonEmpty ? spec.SplitClean ? Content.SplitClean(spec.Delimiter) : Content.Split(spec.Delimiter) : Array.Empty<string>();

        public ReadOnlySpan<string> Split(char delimiter, bool clean = true)
        {
            if(string.IsNullOrWhiteSpace(Content))
                return Array.Empty<string>();
            else
                return clean ? Content.SplitClean(delimiter) : Content.Split(delimiter);
        }

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