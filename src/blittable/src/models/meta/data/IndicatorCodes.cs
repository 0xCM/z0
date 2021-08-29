//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static AsciCode;

    partial struct Blit
    {
        partial struct Types
        {
            internal static ReadOnlySpan<AsciCode> IndicatorCodes
                => new AsciCode[TypeKindCount]{
                    Question,
                    u,
                    i,
                    f,
                    c,
                    e,
                    v,
                    a,
                    t,
                    d,
                    s,
                    g,
                    q,
                    b
                    };
        }
    }
}