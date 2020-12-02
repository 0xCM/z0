//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct GridCalcs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static GridSegment<T> segment<T>(ushort rows, ushort cols, ushort width)
            where T : unmanaged
                => new GridSegment<T>(rows, cols, width);
    }
}