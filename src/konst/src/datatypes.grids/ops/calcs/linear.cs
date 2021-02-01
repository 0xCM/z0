//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct GridCalcs
    {
        /// <summary>
        /// Computes the 0-based linear index determined by column width and a row/col coordinate
        /// </summary>
        /// <param name="colwidth">The bit-width of a grid column</param>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static int linear(int colwidth, int row, int col)
            => row*colwidth + col;

        /// <summary>
        /// Computes the 0-based linear index determined by column width and a row/col coordinate
        /// </summary>
        /// <param name="colwidth">The bit-width of a grid column</param>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static uint linear(uint colwidth, uint row, uint col)
            => row*colwidth + col;

        /// <summary>
        /// Computes the 0-based linear index determined by column width and a row/col coordinate
        /// </summary>
        /// <param name="colwidth">The bit-width of a grid column</param>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static uint linear(GridDim dim, GridPoint point)
            => point.Row*dim.ColCount+ point.Col;

        /// <summary>
        /// Computes the 0-based linear index determined by column width and a row/col coordinate
        /// </summary>
        /// <param name="colwidth">The bit-width of a grid column</param>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static uint linear(GridDim dim, uint row, uint col)
            => linear(dim, (row,col));

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static int linear(in GridMetrics src, int row, int col)
            => linear(src.ColCount, row, col);

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate and natural column width
        /// </summary>
        /// <param name="row">The grid row</param>
        /// <param name="col">The grid columns</param>
        /// <typeparam name="N">The grid column type</typeparam>
        [MethodImpl(Inline)]
        public static int linear<N>(int row, int col, N n = default)
            where N : unmanaged, ITypeNat
                => row * (int)nat64u<N>() + col;

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate and natural column width
        /// </summary>
        /// <param name="row">The grid row</param>
        /// <param name="col">The grid columns</param>
        /// <typeparam name="N">The grid column type</typeparam>
        [MethodImpl(Inline)]
        public static uint linear<W>(uint row, uint col, W w = default)
            where W : unmanaged, IDataWidth
                => (uint)row * (uint)Widths.data(w) + col;
    }
}