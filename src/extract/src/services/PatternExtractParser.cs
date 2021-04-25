//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using EP = EncodingParser;
    using api = ApiExtracts;

    public readonly struct PatternExtractParser
    {
        readonly byte[] Buffer;

        [MethodImpl(Inline)]
        internal PatternExtractParser(byte[] buffer)
            => Buffer = buffer;

        EP Parser
        {
            [MethodImpl(Inline)]
            get => api.encodings(Buffer.Clear());
        }

        [Op]
        public Index<ApiMemberCode> ParseMembers(ReadOnlySpan<ApiMemberExtract> src)
            => api.parse(Parser,src);
    }
}