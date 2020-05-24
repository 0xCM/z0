//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class BitCalcs
    {
        /// <summary>
        /// Computes the number of bytes covered by a specified number of cells of a given width
        /// </summary>
        /// <param name="cells">The number of allocated cells</param>
        /// <param name="cw">The bit-width of a cell</param>
        [MethodImpl(Inline), Op]
        public static int bytecount(int cells, int cw)
            => cells * (cw/8);

        /// <summary>
        /// Computes the number of bytes that can be covered by a specified number of cells of parametric type
        /// </summary>
        /// <param name="cells">The number of cells</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline),Op, Closures(UnsignedInts)]
        public static int bytecount<T>(int cells)
            where T : unmanaged
                => cells * Control.size<T>();

        /// <summary>
        /// Computes the minimum numbet of bytes required to hold a specified number of bits
        /// </summary>
        /// <param name="bc">The number of bits for which storage is required</param>
        [MethodImpl(Inline), Op]
        public static int minbytes(int bc)
            => bc / 8 + (bc % 8 == 0 ? 0 : 1);  

        /// <summary>
        /// Computes the minimum number of cells required to store a specified number of bits
        /// </summary>
        /// <param name="w">The cell width</param>
        /// <param name="n">The bit count/number of matrix columns</param>
        [MethodImpl(Inline), Op]
        public static int mincells(ulong w, ulong n)
        {
            // if a single cell covers a column then there's no need for computation
            if(w >= n)
                return 1;

            var q = n / w;
            var r = n % w;
            return (int)(r == 0 ? q : q + 1);
        }

        /// <summary>
        /// Computes the minimum number of cells required to store data of a given bit width
        /// </summary>
        /// <param name="bc">The number of bits for which storage is required</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int mincells<T>(ulong bc)
            where T : unmanaged
        {
            if(Control.bitsize<T>() >= (int)bc)
                return 1;

            var q = (int)bc / Control.bitsize<T>();
            var r = (int)bc % Control.bitsize<T>();
            return q + (r != 0 ? 1 : 0);
        }

        /// <summary>
        /// Computes the minimum number of T-cells required to store N bits
        /// </summary>
        /// <param name="n">The bit count representative</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="N">The bit count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int mincells<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatCalc.lteqT(n,t) ? 1 : (int)NatCalc.divceilT(n,t); 

        /// <summary>
        /// Computes the number of packed cells required to cover a rectangular area
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        /// <param name="cw">The storage cell width</param>
        [MethodImpl(Inline), Op]
        public static int tablecells(ulong rows, ulong cols, int cw)
        {
            var bytes = (int)tablesize(rows, cols);
            var segbytes = cw / 8;
            var segs = bytes/segbytes + (bytes % segbytes != 0 ? 1 : 0);            
            return segs;
        }

        /// <summary>
        /// Computes the 0-based linear index determined by column width and a row/col coordinate
        /// </summary>
        /// <param name="colwidth">The bit-width of a grid column</param>
        /// <param name="row">The 0-based row index</param>
        /// <param name="col">The 0-based col index</param>
        [MethodImpl(Inline), Op]
        public static int bitindex(int colwidth, int row, int col)
            => row*colwidth + col;

        /// <summary>
        /// Computes the 0-based linear index determined by a row/col coordinate and natural column width
        /// </summary>
        /// <param name="row">The grid row</param>
        /// <param name="col">The grid columns</param>
        /// <typeparam name="N">The grid column type</typeparam>
        [MethodImpl(Inline)]
        public static int bitindex<N>(int row, int col, N n = default)
            where N : unmanaged, ITypeNat
                => row * (int)TypeNats.value<N>() + col;

        /// <summary>
        /// Computes the number of bytes required to cover a grid, predicated on row/col counts
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        [MethodImpl(Inline), Op]
        public static int tablesize(int rows, int cols)
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
        public static int tablesize(ulong rows, ulong cols)
        {
            var points = (int)(rows*cols);
            return (points >> 3) + (points % 8 != 0 ? 1 : 0);
        }

        /// <summary>
        /// Computes the number of bytes required to cover a grid, predicated on row/col counts
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T tablesize<T>(T rows, T cols)
            where T : unmanaged
        {
            var points = gmath.mul(rows,cols);
            var mod = gmath.mod(points, convert<T>(8));
            var rem = gmath.nonz(mod) ? one<T>() : zero<T>();
            return gmath.add(gmath.srl(points, 3), rem);
        }

        /// <summary>
        /// Computes the number of cells required to cover a rectangular region predicated on the 
        /// parametric cell type and supplied row/col dimensions
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int tablecells<T>(int rows, int cols)
            where T : unmanaged
                => tablecells((ulong)rows, (ulong)cols, Control.bitsize<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int tablecells<T>(ulong rows, ulong cols)
            where T : unmanaged
                => tablecells(rows,  cols, Control.bitsize<T>());

        /// <summary>
        /// Calculates the number of 256-bit blocks reqired to cover a grid with a specified number of rows/cols
        /// </summary>
        /// <param name="w">The block width selctor</param>
        /// <param name="rows">The row count</param>
        /// <param name="cols">The col count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static int tableblocks<T>(N256 w, int rows, int cols)
            where T : unmanaged
                => Blocks.cellcover<T>(w, tablecells<T>((ulong)rows,(ulong)cols));

        /// <summary>
        /// Computes the number of bytes required to cover a rectangular area, predicated on natural row/col counts
        /// </summary>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        [MethodImpl(Inline)]
        public static int tablesize<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var points = (int)NatCalc.mul(m,n);
            return (points >> 3) + (points % 8 != 0 ? 1 : 0);
        }

        /// <summary>
        /// Computes the number of bits covered by a rectangular region and predicated on natural dimensions
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        [MethodImpl(Inline)]
        public static int tablebits<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => (int)NatCalc.mul(m,n);         

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
        public static int tablecells<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => tablecells(value(m), value(n), bitsize<T>());

        /// <summary>
        /// Calculates the number of 256-bit blocks reqired to cover a grid with natural dimensions
        /// </summary>
        /// <param name="w">The block width selctor</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int tableblocks<M,N,T>(N256 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Blocks.cellcover<T>(w, tablecells<T>(value(m), value(n)));        
    }
}