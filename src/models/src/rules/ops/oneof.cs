//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OneOf<T> oneof<T>(params T[] src)
            => new OneOf<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OneOf<T> oneof<T>(ReadOnlySpan<T> src)
            => new OneOf<T>(src.ToArray());
    }
}