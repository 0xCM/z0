//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TextDocFormat
    {
        /// <summary>
        /// Specifies leading content that identifies a non-semantic row division marker
        /// </summary>
        public string RowSeparator {get;}

        /// <summary>
        /// Indicates whether the first line of the data is a header row
        /// </summary>
        public bool HasDataHeader {get;}

        /// <summary>
        /// Specifes whether the file contains regular delimited contetn
        /// </summary>
        public bool IsDelimited {get;}

        /// <summary>
        /// The character used to delimit parts of a line, if delimited
        /// </summary>
        public char Delimiter {get;}

        /// <summary>
        /// If specified, indicates the character that begins a comment
        /// </summary>
        public char CommentPrefix {get;}

        /// <summary>
        /// If specified, defines a uniform column width
        /// </summary>
        public int? ColWidth {get;}

        [MethodImpl(Inline)]
        public static TextDocFormat define(bool HasHeader = true, bool delimited = true,
            char Delimiter = Chars.Pipe, char CommentPrefix = Chars.Hash, int? ColWidth = null)
                => new TextDocFormat(HasHeader, delimited, Delimiter, CommentPrefix,ColWidth);

        [MethodImpl(Inline)]
        internal TextDocFormat(string empty)
            : this()
        {
            RowSeparator = EmptyString;
        }

        [MethodImpl(Inline)]
        public TextDocFormat(bool header, bool delimited, char sep, char cp, int? colwidth)
        {
            RowSeparator = "-------------------------------------------------------";
            HasDataHeader = header;
            IsDelimited = delimited;
            Delimiter = sep;
            CommentPrefix = cp;
            ColWidth = colwidth;
        }

        public static TextDocFormat Empty
            => new TextDocFormat(EmptyString);

        public static TextDocFormat Structured
            => define();

        public static TextDocFormat Unstructured
            => define(false, false);
    }
}