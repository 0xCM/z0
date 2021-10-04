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
        public static Production<T> production<T>(Label name, params T[] terms)
            where T : ITerm
                => new Production<T>(name,terms);

        public static Production<Atom<char>> production(Label name, params char[] src)
            => new Production<Atom<char>>(name, src.Map(x => new Atom<char>(x)));
    }
}