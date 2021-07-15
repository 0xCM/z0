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

    partial struct LookupTables
    {
        [MethodImpl(Inline), Op]
        public static bool eq(LookupKey a, LookupKey b)
            => data(a) == data(b);

        [MethodImpl(Inline), Op]
        public static uint hash(LookupKey src)
            => data(src);
    }
}