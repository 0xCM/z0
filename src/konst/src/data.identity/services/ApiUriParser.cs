//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    using api = ApiUri;

    public readonly struct ApiUriParser : ITextParser<OpUri>
    {
        public static ApiUriParser Service => default;

        public ParseResult<OpUri> Parse(string text)
            => api.parse(text);
    }
}