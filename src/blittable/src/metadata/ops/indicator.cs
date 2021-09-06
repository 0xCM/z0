//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        partial struct Types
        {
            [MethodImpl(Inline), Op]
            public static TypeIndicator indicator(BlittableKind src)
                => default;
        }
    }
}