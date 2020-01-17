//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {        
        /// <summary>
        /// Retuns a one-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> ones<T>(N16 n, int rows, int cols, T t = default)
            where T : unmanaged
                => init16<T>(rows,cols, ushort.MaxValue);

        /// <summary>
        /// Retuns a one-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> ones<T>(N32 n, int rows, int cols, T t = default)
            where T : unmanaged
                => init32<T>(rows,cols, uint.MaxValue);

        /// <summary>
        /// Retuns a one-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> ones<T>(N64 n, int rows, int cols, T t = default)
            where T : unmanaged
                => init64<T>(rows,cols, ulong.MaxValue);

        /// <summary>
        /// Returns a 1-filled natural bitgrid 
        /// </summary>
        /// <param name="width">The grid width</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<M,N,T> ones<M,N,T>(N16 width, M m = default, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ushort.MaxValue;

        /// <summary>
        /// Returns a 1-filled natural bitgrid 
        /// </summary>
        /// <param name="width">The grid width</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<M,N,T> ones<M,N,T>(N32 width, M m = default, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => uint.MaxValue;

        /// <summary>
        /// Returns a 1-filled natural bitgrid 
        /// </summary>
        /// <param name="width">The grid width</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<M,N,T> ones<M,N,T>(N64 width, M m = default, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => ulong.MaxValue;

        /// <summary>
        /// Returns a 1-filled natural bitgrid 
        /// </summary>
        /// <param name="width">The grid width</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<M,N,T> ones<M,N,T>(N128 width, M m = default, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => VPattern.vones<T>(width);

        /// <summary>
        /// Returns a 1-filled natural bitgrid 
        /// </summary>
        /// <param name="width">The grid width</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> ones<M,N,T>(N256 width, M m = default, N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
                => VPattern.vones<T>(width);

        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> ones<M,N,T>(in BitGrid<M,N,T> dst)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            broadcast(maxval<T>(), dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> ones<M,N,T>(M m = default, N n = default, T zero = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            var dst = alloc<M,N,T>();
            ones(dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> ones<T>(in BitGrid<T> dst)
            where T : unmanaged
        {
            broadcast(maxval<T>(), dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static BitGrid<T> ones<T>(int rows, int cols, T zero = default)
            where T : unmanaged
        {
            var dst = alloc<T>(rows,cols);
            ones(dst);
            return dst;
        }
    }
}