//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    public readonly struct AsmParsers
    {
        public const string LocatedMarker = "located://";

        public const char Assign = Chars.Eq;

        public const char CommentMarker = Chars.Semicolon;

        [Op]
        public static bool parse(string[] lines, out AsmBlockHeader dst)
        {
            var fail = ParseResult.fail<AsmBlockHeader>(lines.Concat(Chars.NL));
            dst = default;

            if(lines.Length < 4)
                return false;

            var l0 = lines[0].RightOfFirst(CommentMarker);
            var sig = l0.LeftOfFirst(LocatedMarker);
            var uriParse = ApiUri.parse(text.concat(LocatedMarker,l0.RightOfFirst(LocatedMarker)));
            if(uriParse.Failed)
                return fail;

            var uri = uriParse.Value;
            var prop = lines[1].RightOfFirst(CommentMarker);
            var l2Parts = lines[2].RightOfFirst(CommentMarker).SplitClean(Assign);
            var baseText = l2Parts.Length == 2 ? l2Parts[1] : string.Empty;
            var @base = address(HexScalarParser.Service.Parse(baseText).ValueOrDefault(0ul));
            var l3Parts = lines[3].RightOfFirst(CommentMarker).SplitClean(Assign);
            var tcText = l3Parts.Length == 2 ? l3Parts[1] : string.Empty;
            var tcVal = Enums.parse(tcText, ExtractTermCode.None);

            dst = new AsmBlockHeader(uri, sig, prop, @base, tcVal);
            return true;
        }
    }
}