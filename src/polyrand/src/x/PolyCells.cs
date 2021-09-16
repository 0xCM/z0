//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public static class PolyCells
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

        [MethodImpl(Inline), Op]
        public static Cell8 Cell(this ISource src, W8 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell16 Cell(this ISource src, W16 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell32 Cell(this ISource src, W32 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell64 Cell(this ISource src, W64 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell128 Cell(this ISource src, W128 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell256 Cell(this ISource src, W256 w)
            => Sources.cell(src, w);

        [MethodImpl(Inline), Op]
        public static Cell512 Cell(this ISource src, W512 w)
            => Sources.cell(src, w);
    }
}