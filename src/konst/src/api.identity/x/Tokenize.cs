//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    using api = ApiIdentity;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static ApiIdentityToken Tokenize(this OpIdentity src)
            => ApiIdentity.token(src);
    }
}