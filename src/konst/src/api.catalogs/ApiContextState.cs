//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiContextState
    {
        internal readonly IApiPartSet ApiParts;

        [MethodImpl(Inline)]
        internal ApiContextState(IApiPartSet src)
        {
            ApiParts = src;
        }
    }
}