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
        /// <param name="src">The random source</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static IEnumerable<F> CellStream<F>(this IDataSource src)
            where F: unmanaged, IDataCell
                => Sources.cells(create<F>(src));
    }
}