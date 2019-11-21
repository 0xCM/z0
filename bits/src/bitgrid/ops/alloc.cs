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
        /// Allocates a generic bitgrid predicated on row/col count and parametric storage segment type
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> alloc<T>(ushort rows, ushort cols)
            where T : unmanaged
        {            
            Span<T> data = new T[segcount<T>(rows,cols)];
            return new BitGrid<T>(data, rows, cols);
        }

        /// <summary>
        /// Allocates a natural bitgrid predicated on parametric types
        /// </summary>
        /// <typeparam name="M">The number of rows in the grid</typeparam>
        /// <typeparam name="N">The number of columns in the grid</typeparam>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> alloc<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> data = new T[segcount(m,n,zero)];
            return new BitGrid<M, N, T>(data);
        }



    }

}