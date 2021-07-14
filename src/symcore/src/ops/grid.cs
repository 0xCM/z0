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
        public static SymGrid<R,C> grid<R,C>(Symbols<R> rows, Symbols<C> cols)
            where R : unmanaged
            where C : unmanaged
                => new SymGrid<R,C>(rows, cols);
    }
}