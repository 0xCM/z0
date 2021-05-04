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
        public static Intersperse<T> intersperse<T>(T insert)
            => new Intersperse<T>(insert);

        [Op, Closures(Closure)]
        public static Interspersed<T> apply<T>(Intersperse<T> rule, Index<T> src)
            => interspersed(src.Storage.Intersperse(rule.Element), rule);
    }
}