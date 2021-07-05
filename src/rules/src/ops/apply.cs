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
        [Op, Closures(Closure)]
        public static Interspersal<T> apply<T>(Intersperse<T> rule, Index<T> src)
            => interspersed(src.Storage.Intersperse(rule.Element), rule);
    }
}