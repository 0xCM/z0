//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = ApiUri;

    public readonly struct OpIdentityParser : IParser<string,OpIdentity>
    {
        public static OpIdentityParser Service => default(OpIdentityParser);

        [MethodImpl(Inline)]
        public static OpIdentity parse(string src)
            => api.operation(src);

        [MethodImpl(Inline)]
        public OpIdentity Parse(string text)
            => api.operation(text);

        ParseResult<string, OpIdentity> IParser<string, OpIdentity>.Parse(string src)
            => z.parsed(src, Parse(src));

    }
}