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

    partial class NumericKinds
    {
        [MethodImpl(Inline)]
        public static IEnumerable<T> seq<T>(params T[] src)
            => src;
    }
}