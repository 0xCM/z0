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
    /// Defines a text document format scheme
    /// </summary>
    public struct TextDocFormat
    {
        /// <summary>
        /// Specifies the default delimiter to use with structured content
        /// </summary>
        public const char DefaultDelimiter = Chars.Pipe;

        /// <summary>
        /// Specifies the default comment prefix
        /// </summary>
        public const char DefaultCommentPrefix = Chars.Hash;

        /// <summary>
        /// Specifies the default row block separator
        /// </summary>
        public const string DefaultRowBlockSep = "-------------------------------------------------------";

        /// <summary>
        /// Specifies leading content that identifies a non-semantic row division marker
        /// </summary>
        public string RowBlockSep;

        /// <summary>
        /// Indicates whether the first line of the data is a header row
        /// </summary>
        public bool HasDataHeader;

        /// <summary>
        /// Specifes whether the file contains regular delimited contetn
        /// </summary>
        public bool IsDelimited;

        /// <summary>
        /// The character used to delimit parts of a line, if delimited
        /// </summary>
        public char Delimiter;

        /// <summary>
        /// If specified, indicates the character that begins a comment
        /// </summary>
        public char CommentPrefix;

        /// <summary>
        /// If specified, defines a uniform column width
        /// </summary>
        public uint? ColWidth;

        /// <summary>
        /// Specifies the line number at which pertinent content begins
        /// </summary>
        public uint FirstLine;

        /// <summary>
        /// If specified, indicates the line number at which pertinent content ends
        /// </summary>
        public uint? LastLine;

        [MethodImpl(Inline)]
        public static TextDocFormat Structured()
            => define();

        [MethodImpl(Inline)]
        public static TextDocFormat Structured(char delimiter)
            => define(
                Delimiter: delimiter
                );

        public static TextDocFormat Unstructured()
            => define(false, false);

        [MethodImpl(Inline)]
        static TextDocFormat define(
            bool HasHeader = true,
            bool delimited = true,
            char Delimiter = DefaultDelimiter,
            char CommentPrefix = DefaultCommentPrefix,
            uint? ColWidth = null,
            uint? FirstLine = null,
            uint? LastLine = null)
        {
            var dst = Empty;
            dst.RowBlockSep = DefaultRowBlockSep;
            dst.HasDataHeader = HasHeader;
            dst.IsDelimited = delimited;
            dst.Delimiter = Delimiter;
            dst.CommentPrefix = CommentPrefix;
            dst.ColWidth = ColWidth;
            dst.FirstLine = FirstLine ?? 0;
            dst.LastLine = LastLine;
            return dst;
        }


        public static TextDocFormat Empty
        {
            [MethodImpl(Inline)]
            get => define(false, false, Chars.Null, Chars.Null, null);
        }


    }
}