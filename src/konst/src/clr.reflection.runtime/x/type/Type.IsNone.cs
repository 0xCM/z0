//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XClrQuery
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool IsNone<T>(this T? src)
            where T : struct
                => !src.HasValue;
    }
}