//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Symbols
    {
        internal static SymCache<E> cache<E>()
            where E : unmanaged, Enum
                => SymCache<E>.get();

        [MethodImpl(Inline)]
        public static Symbols<E> symbolic<E>()
            where E : unmanaged, Enum
                => cache<E>();
    }
}