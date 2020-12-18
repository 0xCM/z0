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

    [ApiHost]
    public readonly struct BitCalcs
    {
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
            var mod = gmath.mod(points, NumericCast.force<T>(8));
            var rem = gmath.nonz(mod) ? one<T>() : zero<T>();
            return gmath.add(gmath.srl(points, 3), rem);
        }

        [MethodImpl(Inline), Op]
        public static ulong tablesize(ulong rows, ulong cols)
        {
            var points = rows*cols;
            var mod = math.mod(points, 8ul);
            var rem = math.nonz(mod) ? 1ul : 0ul;
            return math.add(math.srl(points, 3), rem);
        }

        /// <summary>
        /// Computes the number of cells required to cover a rectangular region predicated on the
        /// parametric cell type and supplied row/col dimensions
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong cellcount<T>(uint rows, uint cols)
            where T : unmanaged
                => GridCalcs.cellcount(rows, cols, bitwidth<T>());

        /// <summary>
        /// Calculates the number of 256-bit blocks reqired to cover a grid with a specified number of rows/cols
        /// </summary>
        /// <param name="w">The block width selctor</param>
        /// <param name="rows">The row count</param>
        /// <param name="cols">The col count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong tableblocks<T>(N256 w, uint rows, uint cols)
            where T : unmanaged
                => SpanBlocks.cellcover<T>(w, cellcount<T>(rows,cols));

        /// <summary>
        /// Computes the number of bits covered by a rectangular region and predicated on natural dimensions
        /// </summary>
        /// <param name="rows">The grid row count</param>
        /// <param name="cols">The grid col count</param>
        [MethodImpl(Inline)]
        public static ulong tablebits<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => NatCalc.mul(m,n);

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
        public static ulong tablecells<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => GridCalcs.cellcount((uint)nat64u(m), (uint)nat64u(n), bitwidth<T>());

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
        public static ulong tableblocks<M,N,T>(N256 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => SpanBlocks.cellcover<T>(w, cellcount<T>((uint)nat64u(m), (uint)nat64u(n)));
    }
}