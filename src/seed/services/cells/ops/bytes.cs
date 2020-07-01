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
        /// <summary>
        /// Computes dimension information for a grid predicated on parametric types
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static GridDim<M,N,T> dimension<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        /// <summary>
        /// Computes the minimum number of bytes required to cover a specified number of bits
        /// </summary>
        /// <param name="bits">The number of bits for which storage is required</param>
        [MethodImpl(Inline), Op]
        public static int minbytes(int bits)
            => bits / 8 + (bits % 8 == 0 ? 0 : 1);  

        /// <summary>
        /// Computes the number of bytes that can be covered by a specified number of cells of parametric type
        /// </summary>
        /// <param name="cells">The number of cells</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(UnsignedInts)]
        public static int bytes<T>(int cells)
            where T : unmanaged
                => cells * size<T>();

        /// <summary>
        /// Computes the number of bytes required to cover a grid, predicated on row/col counts
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        [MethodImpl(Inline), Op]
        public static int bytes(int rows, int cols)
        {
            var points = rows*cols;
            return (points >> 3) + (points % 8 != 0 ? 1 : 0);
        }

        /// <summary>
        /// Computes the number of bytes required to cover a grid, predicated on row/col counts
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        [MethodImpl(Inline), Op]
        public static int bytes(ulong rows, ulong cols)
        {
            var points = (int)(rows*cols);
            return (points >> 3) + (points % 8 != 0 ? 1 : 0);
        }
    }
}