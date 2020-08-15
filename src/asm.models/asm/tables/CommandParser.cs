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
        public const string LocatedMarker = "located://";

        public const char Assign = Chars.Eq;

        public const string BlockSepMarker = "-----";

        public const string DescriptorSep = "||";       

        public const char BodySep = Chars.Semicolon;

        public const char CommentMarker = Chars.Semicolon;

        [MethodImpl(Inline), Op]
        public static bool IsCommentLine(string src)
            => src.Trim().StartsWith(CommentMarker);

        [MethodImpl(Inline), Op]
        public static bool IsBlockSep(string src)
            => src.Trim().StartsWith(BlockSepMarker);

        [MethodImpl(Inline), Op]
        public static bool IsBlankLine(string src)
            => string.IsNullOrWhiteSpace(src);
    }
}