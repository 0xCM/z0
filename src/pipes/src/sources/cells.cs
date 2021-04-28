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
        [MethodImpl(Inline)]
        public static CellSource<F> cellsource<F>(ISource provider)
            where F : struct, IDataCell
                => new CellSource<F>(provider);

        [MethodImpl(Inline), Op]
        public static CellSource cellsource(ISource provider)
            => new CellSource(provider);

        public static IEnumerable<F> cells<F>(ICellValues<F> source)
            where F : struct, IDataCell
        {
            while(true)
                yield return source.Next();
        }

        [Op, Closures(Closure)]
        public static IEnumerable<Cell128> cells<T>(ISource src, W128 w)
            where T : unmanaged
                => new CellStream<Cell128,W128,T>(src).Stream;

        public static IEnumerable<F> cells<F,W,T>(ISource src, F f = default, T t = default)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStream<F,W,T>(src).Stream;

        public static IEnumerable<F> cells<F,W,T>(ISource src)
            where F : unmanaged, IDataCell
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellStream<F,W,T>(src).Stream;

        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> cells<F>(ISource src)
            where F: unmanaged, IDataCell
                => cells(cellsource<F>(src));

        /// <summary>
        /// Creates a cell index of specified count
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="src">The cell count</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static Index<F> cells<F>(ISource src, uint count)
            where F: unmanaged, IDataCell
                => cells<F>(src).Take(count).Array();
    }
}