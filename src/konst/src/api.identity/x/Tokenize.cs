//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = ApiIdentity;

    partial class XApiIdentity
    {
        [MethodImpl(Inline)]
        public static ApiIdentityToken Tokenize(this OpIdentity src)
            => api.token(src);
    }
}