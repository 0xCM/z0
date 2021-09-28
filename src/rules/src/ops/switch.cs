//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Rules
    {
        public static Switch<K,A> @switch<K,A>(Identifier name, K[] choices, Func<K,A> actor)
            => new Switch<K,A>(name, choices, actor);
    }
}