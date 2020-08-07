//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct TextLineParser : ITextParser<TextDocLine[]>
    {
        public static TextLineParser Service => default;

        public ParseResult<TextDocLine[]> Parse(string src)
            => TextDocParser.lines(src);
    }
}