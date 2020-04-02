//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static ClrType<T> type<T>()
            => ClrType.From<T>();
    }
}