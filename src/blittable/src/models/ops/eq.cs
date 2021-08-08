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
            public static bit eq(name64 a, name64 b)
                => a.Storage == b.Storage;

            [MethodImpl(Inline), Op]
            public static bit neq(name64 a, name64 b)
                => a.Storage != b.Storage;
        }
    }
}