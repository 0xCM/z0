//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGridX
    {   
        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid16<T> g)
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid32<T> g)
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid64<T> g)
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this BitGrid<T> g)
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid16<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid32<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid64<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid128<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.bitstring(g);


        /// <summary>
        /// Converts a grid to an equivalent linear bitstring representation
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<M,N,T>(this BitGrid256<M,N,T> g)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.bitstring(g);

        /// <summary>
        /// Hydrates a bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="w">The grid bit-width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> ToBitGrid<T>(this BitString bs, N16 w, int rows, int cols, T t = default)
            where T : unmanaged
                => BitGrid.parse<T>(bs, w, rows, cols);

        /// <summary>
        /// Hydrates a bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="w">The grid bit-width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> ToBitGrid<T>(this BitString bs, N32 w, int rows, int cols, T t = default)
            where T : unmanaged
                => BitGrid.parse<T>(bs, w, rows, cols);

        /// <summary>
        /// Hydrates a bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="w">The grid bit-width selector</param>
        /// <param name="m">The row count</param>
        /// <param name="n">The col count</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> ToBitGrid<T>(this BitString bs, N64 w, int rows, int cols,  T t = default)
            where T : unmanaged
                => BitGrid.parse(bs,w,rows,cols,t);

        /// <summary>
        /// Hydrates a bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="w">The grid bit-width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> ToBitGrid<M,N,T>(this BitString bs, N32 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.parse(bs,w,m,n,t);

        /// <summary>
        /// Hydrates a bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="w">The grid bit-width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> ToBitGrid<M,N,T>(this BitString bs, N64 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.parse(bs,w,m,n,t);

        /// <summary>
        /// Hydrates a bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="w">The grid bit-width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> ToBitGrid<M,N,T>(this BitString bs, N128 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.parse(bs,w,m,n,t);

        /// <summary>
        /// Hydrates a bitgrid from a bitstring
        /// </summary>
        /// <param name="bs">The source bitstring</param>
        /// <param name="w">The grid bit-width selector</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> ToBitGrid<M,N,T>(this BitString bs, N256 w, M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitGrid.parse(bs,w,m,n,t);                 
   }
}