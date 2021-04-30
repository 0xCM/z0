//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class XSource
    {
        /// <summary>
        /// Creates a stream of fixed values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> Cells<F>(this ISource src)
            where F: unmanaged, IDataCell
                => Sources.cellstream<F>(src);

        /// <summary>
        /// Creates a cell index of specified count
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="src">The cell count</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static Index<F> Cells<F>(this ISource src, uint count)
            where F: unmanaged, IDataCell
                => Sources.celldata<F>(src, count);
    }
}