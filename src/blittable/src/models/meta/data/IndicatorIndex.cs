//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static AsciCode;

    partial struct Blit
    {
        partial struct Types
        {
            internal static ReadOnlySpan<byte> IndicatorIndex
                => new byte[TypeKindCount*2]{
                    (byte)Question,0,
                    (byte)u,1,
                    (byte)i,2,
                    (byte)f,3,
                    (byte)c,4,
                    (byte)e,5,
                    (byte)v,6,
                    (byte)a,7,
                    (byte)t,8,
                    (byte)d,9,
                    (byte)s,10,
                    (byte)g,11,
                    (byte)q,12,
                    (byte)b,13
                    };
        }
    }
}