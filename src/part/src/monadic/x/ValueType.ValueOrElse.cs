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

    using static Part;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static T ValueOrElse<T>(this T? x,  Func<T> @else)
            where T : struct
                => x != null ? x.Value : @else();

        [MethodImpl(Inline)]
        public static T ValueOrElse<T>(this T? x, T @else)
            where T : struct
                => x != null ? x.Value : @else;
    }
}