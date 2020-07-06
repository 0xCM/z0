//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    
    partial struct Cells
    {
        [MethodImpl(Inline)]
        public static ConversionMetrics<S,T> conversion<S,T>(uint srcCount)
            where S : struct
            where T : struct
                => ConversionMetrics.define<S,T>(srcCount);        
                
        /// <summary>
        /// Calculates memory block statistics for specified parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width</param>
        /// <param name="cw">The cell width</param>
        [MethodImpl(Inline), Op]
        public static CellMetrics metrics(int bc, int bw, int cw)
            => new CellMetrics(bc, bw, cw);

        /// <summary>
        /// Calculates memory block statistics for specified function and type parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width</param>
        /// <typeparam name="T">The type that determines cell width</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static CellMetrics<T> metrics<T>(int bc, int bw)
            where T : unmanaged
                => new CellMetrics<T>(bc, bw);

        /// <summary>
        /// Calculates memory block statistics for specified function and type parameters
        /// </summary>
        /// <param name="bc">The block count</param>
        /// <param name="bw">The block width representative</param>
        /// <param name="t">The block cell type representative</param>
        /// <typeparam name="N">The type that dermines block width</typeparam>
        /// <typeparam name="T">The type that determines cell width</typeparam>
        [MethodImpl(Inline)]
        public static CellMetrics<W,T> metrics<W,T>(int bc, W bw = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => new CellMetrics<W,T>(bc);        

        /// <summary>
        /// Calculates a grid layout from a specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        [MethodImpl(Inline), Op]
        public static GridMetrics metrics(in GridSpec spec)
            => new GridMetrics(spec);

        /// <summary>
        /// Defines a grid map predicated row count, col count and storage segment bit width width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a grid cell</param>
        [MethodImpl(Inline), Op]
        public static GridMetrics gmetrics(ushort rows, ushort cols, ushort segwidth)    
             => metrics(Cells.grid(rows, cols, segwidth));

        /// <summary>
        /// Defines a grid map predicated row count, col count and the bit width of parametric type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static GridMetrics gmetrics<T>(ushort rows, ushort cols)    
            where T : unmanaged
                => metrics(Cells.grid<T>(rows,cols));

        /// <summary>
        /// Defines a grid map predicated on type parameters
        /// </summary>
        /// <param name="RowCount">The number of rows in the grid</param>
        /// <param name="ColCount">The number of columns in the grid</param>
        /// <param name="CellWidth">The width of a grid cell</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static GridMetrics gmetrics<M,N,T>(M m = default, N n = default, T zero = default)    
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => metrics(Cells.grid(m,n, zero));
    }
}