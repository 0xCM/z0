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
        [MethodImpl(Inline), Op]
        public static bit eq(text7 a, text7 b)
            => a.Storage == b.Storage;

        [MethodImpl(Inline), Op]
        public static bit neq(text7 a, text7 b)
            => a.Storage != b.Storage;
    }
}