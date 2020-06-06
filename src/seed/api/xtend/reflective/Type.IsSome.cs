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

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static bool IsSome<T>(this T? src)
            where T : struct
                => src.HasValue;
    }
}