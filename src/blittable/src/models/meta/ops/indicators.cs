//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        partial struct Types
        {
            [MethodImpl(Inline), Op]
            public static ReadOnlySpan<Blit.TypeIndicator> indicators()
                => recover<AsciCode,Blit.TypeIndicator>(IndicatorCodes);
        }
    }
}
