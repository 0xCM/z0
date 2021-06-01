//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;

    [ApiHost]
    public class Dimensions
    {
        /// <summary>
        /// Constructs an natural dimension of order 2
        /// </summary>
        /// <typeparam name="M">The type of the first axis</typeparam>
        /// <typeparam name="N">The type of the second axis</typeparam>
        [MethodImpl(Inline)]
        public static Dim<M,N> dim<M,N>(M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Computes dimension information for a blocked grid predicated on parametric types
        /// </summary>
        /// <param name="w">The block width representative</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="W">The block width</typeparam>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        public static GridDim<W,M,N,T> dim<W,M,N,T>(W w = default, M m = default, N n = default, T t = default)
            where W : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static GridTypeExpr<N64,N8,N8,T> expression<T>(T t = default)
            where T : unmanaged
                => expression(n64, n8,n8, t);

        /// <summary>
        /// Defines a parametrically-specified grid type expression
        /// </summary>
        /// <typeparam name="W">The block width type</typeparam>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The storage cell type</typeparam>
        [MethodImpl(Inline)]
        public static GridTypeExpr<W,M,N,T> expression<W,M,N,T>(W w = default, M m = default, N n = default, T t = default)
            where W : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => default;
    }
}