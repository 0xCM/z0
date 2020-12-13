//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Konst;

    partial struct CellSource
    {
        public static IEnumerable<F> stream<F>(ICellValues<F> source)
            where F : struct, IDataCell
        {
            while(true)
                yield return source.Next();
        }

        [Op, Closures(UnsignedInts)]
        public static IEnumerable<Cell128> stream<T>(IPolyrand random, W128 w)
            where T : unmanaged
                => new CellStreamer<Cell128,W128,T>(random).Stream;

        public static IEnumerable<F> stream<F,W,T>(IPolyrand random, F f = default, T t = default)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStreamer<F,W,T>(random).Stream;

        public static IEnumerable<F> stream<F,W,T>(IPolyrand random)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStreamer<F,W,T>(random).Stream;
    }
}