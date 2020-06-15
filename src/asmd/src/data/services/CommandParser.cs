//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial class AsmCommandParser
    {
        public static ParseResult<AsmCommand> ParseAsmLine(string line, ref int seq)
            => AsmSourceLineParser.Service.Parse(line, ref seq);

        internal const string LocatedMarker = "located://";

        internal const char Assign = Chars.Eq;

        internal const string BlockSepMarker = "-----";

        internal const string DescriptorSep = "||";       

        internal const char BodySep = Chars.Semicolon;

        internal const char CommentMarker = Chars.Semicolon;

        [MethodImpl(Inline)]
        internal static bool IsCommentLine(string src)
            => src.Trim().StartsWith(CommentMarker);

        [MethodImpl(Inline)]
        internal static bool IsBlockSep(string src)
            => src.Trim().StartsWith(BlockSepMarker);

        [MethodImpl(Inline)]
        internal static bool IsBlankLine(string src)
            => string.IsNullOrWhiteSpace(src);
    }
}