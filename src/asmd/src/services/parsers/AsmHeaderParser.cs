//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static AsmCommandParser;

    public readonly struct AsmHeaderParser : ITextParser<AsmFunctionHeader>
    {
        public static AsmHeaderParser Service => default(AsmHeaderParser);

        public ParseResult<AsmFunctionHeader> Parse(string[] lines)
        {
            var fail = ParseResult.Fail<AsmFunctionHeader>(lines.Concat(Chars.NL));

            if(lines.Length < 4)
                return fail;

            var l0 = lines[0].RightOf(CommentMarker);
            var sig = l0.LeftOf(LocatedMarker);
            var uriParse = OpUriParser.The.Parse(text.concat(LocatedMarker,l0.RightOf(LocatedMarker)));
            if(uriParse.Failed)
                return fail;
            var uri = uriParse.Value;

            var prop = lines[1].RightOf(CommentMarker);

            var l2Parts = lines[2].RightOf(CommentMarker).SplitClean(Assign);
            var baseText = l2Parts.Length == 2 ? l2Parts[1] : string.Empty;
            var @base = MemoryAddress.From(HexScalarParser.Service.Parse(baseText).ValueOrDefault(0ul));
            
            var l3Parts = lines[3].RightOf(CommentMarker).SplitClean(Assign);
            var tcText = l3Parts.Length == 2 ? l3Parts[1] : string.Empty;
            var tcVal = Enums.Parse(tcText, ExtractTermCode.None);

            return ParseResult.Success(lines.Concat(Chars.NL), new AsmFunctionHeader(uri, sig, prop, @base, tcVal));
        }

        public ParseResult<AsmFunctionHeader> Parse(string src)
            => Parse(src.SplitClean(Chars.NL));

    }
}