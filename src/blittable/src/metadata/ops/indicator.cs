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
            public static Blit.TypeIndicator indicator(BlittableKind src)
                => new Blit.TypeIndicator((ushort)skip(IndicatorCodes,(byte)src));
        }
    }
}