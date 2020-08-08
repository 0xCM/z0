//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public partial class AsmCommandParser
    {
        internal const string LocatedMarker = "located://";

        internal const char Assign = Chars.Eq;

        internal const string BlockSepMarker = "-----";

        internal const string DescriptorSep = "||";       

        internal const char BodySep = Chars.Semicolon;

        internal const char CommentMarker = Chars.Semicolon;

        [MethodImpl(Inline), Op]
        internal static bool IsCommentLine(string src)
            => src.Trim().StartsWith(CommentMarker);

        [MethodImpl(Inline), Op]
        internal static bool IsBlockSep(string src)
            => src.Trim().StartsWith(BlockSepMarker);

        [MethodImpl(Inline), Op]
        internal static bool IsBlankLine(string src)
            => string.IsNullOrWhiteSpace(src);
    }
}