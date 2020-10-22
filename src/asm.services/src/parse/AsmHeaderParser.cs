//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static AsmCommandParser;

    [ApiHost]
    public readonly struct AsmHeaderParser : ITextParser<AsmRoutineHeader>
    {
        public static AsmHeaderParser Service => default(AsmHeaderParser);

        [Op]
        public ParseResult<AsmRoutineHeader> Parse(string[] lines)
        {
            var fail = ParseResult.Fail<AsmRoutineHeader>(lines.Concat(Chars.NL));

            if(lines.Length < 4)
                return fail;

            var l0 = lines[0].RightOfFirst(CommentMarker);
            var sig = l0.LeftOfFirst(LocatedMarker);
            var uriParse = ApiUriParser.Service.Parse(text.concat(LocatedMarker,l0.RightOf(LocatedMarker)));
            if(uriParse.Failed)
                return fail;
            var uri = uriParse.Value;

            var prop = lines[1].RightOfFirst(CommentMarker);

            var l2Parts = lines[2].RightOfFirst(CommentMarker).SplitClean(Assign);
            var baseText = l2Parts.Length == 2 ? l2Parts[1] : string.Empty;
            var @base = z.address(HexScalarParser.Service.Parse(baseText).ValueOrDefault(0ul));

            var l3Parts = lines[3].RightOfFirst(CommentMarker).SplitClean(Assign);
            var tcText = l3Parts.Length == 2 ? l3Parts[1] : string.Empty;
            var tcVal = Enums.parse(tcText, ExtractTermCode.None);

            return ParseResult.Success(lines.Concat(Chars.NL), new AsmRoutineHeader(uri, sig, prop, @base, tcVal));
        }

        [Op]
        public ParseResult<AsmRoutineHeader> Parse(string src)
            => Parse(src.SplitClean(Chars.NL));
    }
}