//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Grids
    {

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Grid<T> grid<T>(GridDim dim, T[] data)
            => new Grid<T>(dim, data);
    }
}