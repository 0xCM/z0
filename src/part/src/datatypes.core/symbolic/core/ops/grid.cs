//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Symbols
    {
        [MethodImpl(Inline)]
        public static SymGrid<K> kgrid<K>(Symbols<K> rows, Symbols<K> cols)
            where K : unmanaged
                => new SymGrid<K>(rows, cols);

        [MethodImpl(Inline)]
        public static SymGrid<R,C> grid<R,C>(Symbols<R> rows, Symbols<C> cols)
            where R : unmanaged
            where C : unmanaged
                => new SymGrid<R,C>(rows, cols);

        public static SymGrid<K> kgrid<K>()
            where K : unmanaged, Enum
                => kgrid<K>(cache<K>(), cache<K>());

        public static SymGrid<R,C> grid<R,C>()
            where R : unmanaged, Enum
            where C : unmanaged, Enum
                => grid<R,C>(cache<R>(), cache<C>());
    }
}