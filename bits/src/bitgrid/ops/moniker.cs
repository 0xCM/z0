//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitGrid
    {
        /// <summary>
        /// Defines a characterizing grid moniker
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="segwidth">The width of a storage segment</param>
        [MethodImpl(Inline)]
        public static GridMoniker moniker(ushort rows, ushort cols, ushort segwidth)
            => GridMoniker.FromSpecs(rows, cols, segwidth);

        /// <summary>
        /// Defines a characterizing grid moniker
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static GridMoniker<T> moniker<T>(ushort rows, ushort cols)
            where T : unmanaged
                => GridMoniker.FromDim<T>(rows, cols);

        /// <summary>
        /// Defines a characterizing grid moniker
        /// </summary>
        /// <param name="rows">The number of rows in the grid</param>
        /// <param name="cols">The number of columns in the grid</param>
        /// <param name="zero">The zero representative of the segment type</param>
        /// <typeparam name="M">The row type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static GridMoniker<T> moniker<M,N,T>(M m = default, N n = default, T zero = default)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => GridMoniker.FromTypes(m,n,zero);
    }
}