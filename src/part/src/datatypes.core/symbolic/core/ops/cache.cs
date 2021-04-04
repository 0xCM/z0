//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct Symbols
    {
        public static SymCache<E> cache<E>()
            where E : unmanaged, Enum
                => SymCache<E>.get();
    }
}