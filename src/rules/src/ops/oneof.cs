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
        public static OneOf<T> oneof<T>(T[] src)
            => new OneOf<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Constraint<T,OneOf<T>> oneof<T>(T subject, T[] src)
            => constrain(subject,oneof(src));
    }
}