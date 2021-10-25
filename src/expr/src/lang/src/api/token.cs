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
        public static Token<S> token<S>(uint key, params Atom<S>[] src)
            where S : unmanaged
                => new Token<S>(key, src);
    }
}