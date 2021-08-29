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
    using static AsciCode;
    using static BlittableKind;

    using K = BlittableKind;


    partial struct Blit
    {
        partial struct Types
        {
            [MethodImpl(Inline), Op]
            public static Blit.TypeIndicator indicator(BlittableKind src)
                => new Blit.TypeIndicator(skip(IndicatorCodes,(byte)src));
        }
    }
}