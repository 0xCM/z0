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
            //TypeKindCount
            internal static ReadOnlySpan<AsciCode> IndicatorCodes
                => new AsciCode[TypeKindCount*2]{
                    Dot,0,
                    u,0,
                    i,0,
                    f,0,
                    c,0,
                    e,0,
                    v,0,
                    a,0,
                    t,0,
                    d,0,
                    s,0,
                    g,0,
                    q,0,
                    b,v,
                    l,0,
                    f,x,
                    m,0,

                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    Dot,Dot,
                    };
        }
    }
}