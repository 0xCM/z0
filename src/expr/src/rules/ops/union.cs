//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Union<T> union<T>(params T[] src)
            => new Union<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Union<T> union<T>(ReadOnlySpan<T> src)
            => new Union<T>(src.ToArray());
    }
}