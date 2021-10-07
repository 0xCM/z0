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
        public static Switch<K,T> @switch<K,T>(Label name, Constant<K>[] choices, T[] terms)
            where K : unmanaged
            where T : ITerm<T>
                => new Switch<K,T>(name, choices, terms);
    }
}