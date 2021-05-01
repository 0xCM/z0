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
        /// <summary>
        /// Creates a cell index of specified count
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="src">The cell count</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static Index<F> celldata<F>(ISource src, uint count)
            where F: unmanaged, IDataCell
                => cellstream<F>(src).Take(count).Array();
    }
}