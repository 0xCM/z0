//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool IsSome<T>(this T? src)
            where T : struct
                => src.HasValue;
    }
}