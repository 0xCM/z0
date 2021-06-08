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

    partial struct Symbols
    {
        [MethodImpl(Inline)]
        public static Symbols<E> index<E>()
            where E : unmanaged, Enum
                => SymCache<E>.get();
    }
}