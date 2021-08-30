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
        partial struct Operate
        {
            [MethodImpl(Inline), Op]
            public static uint hash(text7 src)
                => alg.hash.calc(src.Storage);
        }
    }
}