//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static CellSource;

    partial class XCell
    {
        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> Cells<F>(this IDataSource src)
            where F: unmanaged, IDataCell
                => Sources.cells(create<F>(src));

        /// <summary>
        /// Creates a cell index of specified count
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="src">The cell count</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static Index<F> Cells<F>(this IDataSource src, uint count)
            where F: unmanaged, IDataCell
                => src.Cells<F>().Take(count).Array();
    }
}