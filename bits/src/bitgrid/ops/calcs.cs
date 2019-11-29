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

    public static class BitCalcs
    {
        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate
        /// </summary>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline)]
        public static int bitpos(int gridwidth, int row, int col)
            => row*gridwidth+ col;

        /// <summary>
        /// Computes the number of bytes required to cover a grid, predicated on row/col counts
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        [MethodImpl(Inline)]
        public static int bytecount(int rows, int cols)
        {
            var points = rows*cols;
            return (points >> 3) + (points % 8 != 0 ? 1 : 0);
        }

        /// <summary>
        /// Computes the number of bytes required to cover a grid, predicated on natural row/col counts
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        [MethodImpl(Inline)]
        public static int bytecount<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var points = NatMath.mul(m,n);
            return (points >> 3) + (points % 8 != 0 ? 1 : 0);
        }

        /// <summary>
        /// Computes the number of cells required to cover a grid
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        /// <param name="cellwidth">The storage cell width</param>
        [MethodImpl(Inline)]
        public static int cellcount(int rows, int cols, int cellwidth)
        {
            var bytes = bytecount(rows, cols);
            var segbytes = cellwidth / 8;
            var segs = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);            
            return segs;
        }

        /// <summary>
        /// Computes the number of segments required to cover a grid with specifed storage cell type and dimension
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static int cellcount<T>(int rows, int cols)
            where T : unmanaged
                => cellcount(rows,  cols, bitsize<T>());

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
        public static int cellcount<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => cellcount(natval(m), natval(n), bitsize<T>());

        /// <summary>
        /// Calculates the number of 256-bit blocks reqired to cover a grid with a specified number of rows/cols
        /// </summary>
        /// <param name="block">The block size selctor</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockcount<T>(N256 block, int m, int n, T t = default)
            where T : unmanaged
                => DataBlocks.blockalign<T>(block, cellcount<T>(m,n));

        /// <summary>
        /// Calculates the number of 256-bit blocks reqired to cover a grid with natural dimensions
        /// </summary>
        /// <param name="block">The block size selctor</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockcount<M,N,T>(N256 block, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => DataBlocks.blockalign<T>(block, cellcount<T>(natval(m), natval(n)));


        /// <summary>
        /// Computes the number of points in a grid, predicated on row and column counts
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        [MethodImpl(Inline)]
        public static int pointscount(int rows, int cols)
            => rows * cols;

        /// <summary>
        /// Computes the number of points in a grid, predicated on natural dimensions
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        [MethodImpl(Inline)]
        public static int pointcount<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => NatMath.mul(m,n);         
    }
}