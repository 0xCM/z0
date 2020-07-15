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
    
    partial struct GridCells
    {
        /// <summary>
        /// Computes the number of packed cells required to cover a rectangular area
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        /// <param name="w">The storage cell width</param>
        [MethodImpl(Inline), Op]
        public static uint tablecells(uint rows, uint cols, uint w)
            => count(rows,cols,w);

        /// <summary>
        /// Computes the number of cells required to cover a rectangular region predicated on the 
        /// parametric cell type and supplied row/col dimensions
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint tablecells<T>(uint rows, uint cols)
            where T : unmanaged
                => tablecells(rows, cols, bitsize<T>());
    
        /// <summary>
        /// Computes the number of segments required cover a grid as characterized by parametric type information
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The segment type zero representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static uint tablecells<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => tablecells((uint)value(m), (uint)value(n), bitsize<T>());
    }
}