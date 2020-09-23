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

    partial struct ApiIdentity
    {
        [MethodImpl(Inline), Op]
        public static ApiIdentityToken token(OpIdentity src)
            => ApiIdentityTokens.dispense(src);
    }
}