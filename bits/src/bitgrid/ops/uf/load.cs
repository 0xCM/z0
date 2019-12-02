//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Loads a generic bitgrid from a 256-bit block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="map">The grid map</param>
        /// <typeparam name="T">The segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<T> load<T>(in Block256<T> src, ushort rows, ushort cols)
            where T : unmanaged
                => new BitGrid<T>(src, rows, cols);

        /// <summary>
        /// Loads a natural bitgrid from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="m">The row count representative</param>
        /// <param name="n">The col count representative</param>
        /// <param name="zero">The storage representative</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col type</typeparam>
        /// <typeparam name="T">The storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> load<M,N,T>(Block256<T> src, M m = default, N n = default, T zero = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid<M, N, T>(src);

        [MethodImpl(NotInline)]
        public static BitGrid<M,N,T> load<M,N,T>(M m, N n, Block256<T> src)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => new BitGrid<M,N,T>(src);
    }

}