//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
   
    public readonly struct TextFormat
    {        
        public static TextFormat Structured => Define();

        public static TextFormat Unstructured => Define(false, false);

        [MethodImpl(Inline)]
        public static TextFormat Define(bool HasHeader = true, bool delimited = true, 
            char Delimiter = Chars.Pipe, char CommentPrefix = Chars.Hash, int? ColWidth = null)
                => new TextFormat(HasHeader, delimited, Delimiter, CommentPrefix,ColWidth);
        
        [MethodImpl(Inline)]
        TextFormat(bool header, bool delimited, char sep, char cp, int? colwidth)
        {
            RowSeparator = "-------------------------------------------------------";
            HasDataHeader = header;
            IsDelimited = delimited;
            Delimiter = sep;
            CommentPrefix = cp;
            ColWidth = colwidth;
        }

        /// <summary>
        /// Specifies leading content that identifies a non-semantic row division marker
        /// </summary>
        public readonly string RowSeparator;

        /// <summary>
        /// Indicates whether the first line of the data is a header row
        /// </summary>
        public readonly bool HasDataHeader;

        /// <summary>
        /// Specifes whether the file contains regular delimited contetn
        /// </summary>
        public readonly bool IsDelimited;

        /// <summary>
        /// The character used to delimit parts of a line, if delimited
        /// </summary>
        public readonly char Delimiter;

        /// <summary>
        /// If specified, indicates the character that begins a comment
        /// </summary>
        public readonly char CommentPrefix;

        /// <summary>
        /// If specified, defines a uniform column width
        /// </summary>
        public readonly int? ColWidth;
    }
}