//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Chars;

    partial struct Blit
    {
        partial struct Types
        {
           internal static ReadOnlySpan<char> IndicatorSymbols
                => new char[TypeKindCount]{
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