//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Table
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ulong index64<I>(I index)
            where I : unmanaged
        {
            var storage = 0ul;
            ref var dst = ref @as<I>(storage);
            dst = index;
            return storage;
        }
    }
}