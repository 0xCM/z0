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

    public readonly struct OpIdentityParser : IInfallibleParser<OpIdentity>
    {
        public static OpIdentityParser Service => default(OpIdentityParser);

        OpIdentity INullary<OpIdentity>.Zero
            => OpIdentity.Empty;

        OpIdentity IInfallibleParser<OpIdentity>.Parse(string text)
            => api.operation(text);

        [MethodImpl(Inline)]
        public static OpIdentity parse(string src)
            => api.operation(src);

        [MethodImpl(Inline)]
        public OpIdentity Parse(string text)
            => api.operation(text);
    }
}