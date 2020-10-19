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
        public static TableStore<F,R> store<F,R>()
            where F : unmanaged, Enum
            where R : struct, ITabular
                => default;
    }
}