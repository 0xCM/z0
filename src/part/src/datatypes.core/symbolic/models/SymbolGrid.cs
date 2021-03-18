//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class SymbolGrid<S> : Grid<S>
        where S : unmanaged, ISymbol<S>
    {
        public SymbolGrid(GridDim dim)
            : base(dim)
        {

        }

        [MethodImpl(Inline)]
        public SymbolGrid(GridDim dim, S[] storage)
            : base(dim, storage)
        {

        }
    }
}