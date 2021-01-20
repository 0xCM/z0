//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static z;

    partial struct Sources
    {
        public static IEnumerable<F> cells<F>(ICellValues<F> source)
            where F : struct, IDataCell
        {
            while(true)
                yield return source.Next();
        }

        [Op, Closures(Closure)]
        public static IEnumerable<Cell128> cells<T>(IDataSource src, W128 w)
            where T : unmanaged
                => new CellStreamer<Cell128,W128,T>(src).Stream;

        public static IEnumerable<F> cells<F,W,T>(IDataSource src, F f = default, T t = default)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStreamer<F,W,T>(src).Stream;

        public static IEnumerable<F> cells<F,W,T>(IDataSource src)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStreamer<F,W,T>(src).Stream;
    }
}