//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct Sources
    {
        [Op, Closures(Closure)]
        public static IEnumerable<Cell128> cellstream<T>(ISource src, W128 w)
            where T : unmanaged
                => new CellStream<Cell128,W128,T>(src).Stream;

        public static IEnumerable<F> cellstream<F,W,T>(ISource src, F f = default, W w = default, T t = default)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStream<F,W,T>(src).Stream;

        public static IEnumerable<F> cellstream<F,W,T>(ISource src)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStream<F,W,T>(src).Stream;

        public static IEnumerable<F> cellstream<F>(ICellValues<F> source)
            where F : struct, IDataCell
        {
            while(true)
                yield return source.Next();
        }

        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> cellstream<F>(ISource src)
            where F: unmanaged, IDataCell
                => cellstream(cells<F>(src));
    }
}