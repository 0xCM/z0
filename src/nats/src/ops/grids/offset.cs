//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct GridCalcs
    {
        /// <summary>
        /// Computes the storage segment offset for a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static int offset(in GridMetrics src, int row, int col)
            => CellCalcs.linear(src, row,col) % src.CellWidth;
    }
}