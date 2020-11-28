//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    partial class XSource
    {
        public static Triple<T> Triple<T>(this ISource source, T t = default)
            where T : struct
                => Sources.triple(source, t);
    }
}