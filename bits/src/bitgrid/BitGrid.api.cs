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
    using static AsIn;

    public static partial class BitGrid
    {
        /// <summary>
        /// Allocates a generic bitgrid
        /// </summary>
        /// <param name="rows">The number of grid rows</param>
        /// <param name="cols">The number of grid columns</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> alloc<T>(int rows, int cols)
            where T : unmanaged
        {
            var map = GridLayout.map<T>(rows,cols);
            Span<T> data = new T[map.StorageSegs];
            return new BitGrid<T>(data,map);
        }

        /// <summary>
        /// Allocates a bitgrid of natural dimensions
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
            Span<T> data = new T[segments(m,n,zero)];
            return new BitGrid<M, N, T>(data);
        }

        /// <summary>
        /// Computes the number of segments required to allocate a bitgrid
        /// </summary>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(Inline)]
        public static int segments<T>(int m, int n)
            where T : unmanaged
                => GridLayout.storage<T>(m,n);

        /// <summary>
        /// Computes the number of segments required to allocate natural bitgrid
        /// </summary>
        /// <typeparam name="M">The number of rows in the grid</typeparam>
        /// <typeparam name="N">The number of columns in the grid</typeparam>
        /// <typeparam name="T">The segment type</typeparam>
        public static int segments<M,N,T>(M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => GridLayout.storage<T>(inat<M>(), inat<N>());

        /// <summary>
        /// Loads a generic bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="m">The row count</param>
        /// <param name="n">THe col count</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static ref BitGrid<T> load<T>(Span<T> src, int m, int n, out BitGrid<T> dst)
            where T : unmanaged
        {
            var map = GridLayout.map<T>(m,n);
            require(src.Length >= map.StorageSegs);
            dst = new BitGrid<T>(src, map);
            return ref dst;
        }

        /// <summary>
        /// Loads a generic bitgrid from a span as directed by a specified map
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="map">The grid map</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(NotInline)]
        public static BitGrid<T> load<T>(Span<T> src, GridMap map)
            where T : unmanaged
                => new BitGrid<T>(src, map);

        /// <summary>
        /// Loads a generic bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="m">The row count</param>
        /// <param name="n">THe col count</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> load<T>(Span<T> src, int m, int n)
            where T : unmanaged
                => load(src, m, n, out BitGrid<T> dst);

        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> load<M,N,T>(Span<T> src, M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            require(src.Length == segments(m,n,zero));
            return new BitGrid<M, N, T>(src);
        }

        [MethodImpl(Inline)]
        public static void fill<T>(BitGrid<T> grid, bit state)    
            where T : unmanaged
                => grid.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());

        [MethodImpl(Inline)]
        public static void fill<M,N,T>(BitGrid<M,N,T> grid, bit state)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => grid.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());
    }

    class BitGridInfo<M,N,T>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public static readonly GridMap Map = GridLayout.map<M,N,T>();
    }
}