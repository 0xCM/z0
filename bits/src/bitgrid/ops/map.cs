//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitGrid
    {
        /// <summary>
        /// Defines a grid map predicated row count, col count and storage segment bit width width
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a grid cell</param>
        [MethodImpl(Inline)]
        public static GridMap map(ushort rows, ushort cols, ushort segwidth)    
            => map(specify(rows,cols, segwidth));

        /// <summary>
        /// Defines a grid map predicated row count, col count and the bit width of parametric type
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        [MethodImpl(NotInline)]
        public static GridMap map<T>(ushort rows, ushort cols)    
            where T : unmanaged
                => map(specify<T>(rows,cols));

        /// <summary>
        /// Defines a grid map predicated on type parameters
        /// </summary>
        /// <param name="RowCount">The number of rows in the grid</param>
        /// <param name="ColCount">The number of columns in the grid</param>
        /// <param name="CellWidth">The width of a grid cell</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static GridMap map<M,N,T>(M m = default, N n = default, T zero = default)    
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => map(specify(m,n, zero));

        /// <summary>
        /// Defines a grid map predicated on an existing specification
        /// </summary>
        /// <param name="spec">The grid specification that characterizes the layout</param>
        public static GridMap map(in GridSpec spec)
            => new GridMap(spec);
    }

}