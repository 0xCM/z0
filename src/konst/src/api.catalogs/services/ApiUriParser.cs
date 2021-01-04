//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Service(typeof(ITextParser<OpUri>))]
    readonly struct ApiUriParser : ITextParser<OpUri>
    {
        public ParseResult<OpUri> Parse(string text)
            => ApiUri.parse(text);
    }
}