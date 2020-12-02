//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct GridCalcs
    {
        [MethodImpl(Inline), Op]
        public static uint remainder(in GridMetrics src, W128 w)
            => src.StoreSize % 16;

        [MethodImpl(Inline), Op]
        public static uint remainder(in GridMetrics src, W256 w)
            => src.StoreSize % 32;

        [MethodImpl(Inline), Op]
        public static uint coverage(in GridMetrics src, W128 w)
        {
            var r = remainder(src,w);
            return r != 0 ? r + 1 : r;
        }

        [MethodImpl(Inline), Op]
        public static uint coverage(in GridMetrics src, W256 w)
        {
            var r = remainder(src,w);
            return r != 0 ? r + 1 : r;
        }

        /// <summary>
        /// Computes the storage segment that covers a specified row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static int seg(in GridMetrics src, int row, int col)
            => linear(src,row,col) / src.CellWidth;
    }
}