//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CellCalcs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridSegment<T> segment<T>(GridDim dim, uint segwidth)
            where T : unmanaged
                => new GridSegment<T>(dim, segwidth);
    }
}