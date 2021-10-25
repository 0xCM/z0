//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct lang
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Atom<K> atom<K>(uint key, K value)
            where K : unmanaged
                => new Atom<K>(key, value);

        [MethodImpl(Inline), Op]
        public static Atom atom(char value)
            => new Atom(value);
    }
}