//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = ApiIdentity;

    public readonly struct ApiIdentityParser : IInfallibleParser<OpIdentity>
    {
        public static ApiIdentityParser Service => default(ApiIdentityParser);

        OpIdentity INullary<OpIdentity>.Zero
            => OpIdentity.Empty;

        OpIdentity IInfallibleParser<OpIdentity>.Parse(string text)
            => api.parse(text);

        [MethodImpl(Inline)]
        public static OpIdentity parse(string src)
            => api.parse(src);

        [MethodImpl(Inline)]
        public OpIdentity Parse(string text)
            => api.parse(text);
    }
}