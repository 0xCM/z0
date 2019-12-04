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
        /// Retuns a zero-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid16<T> zeros<T>(N16 n, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Retuns a zero-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid32<T> zeros<T>(N32 n, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Retuns a zero-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid64<T> zeros<T>(N64 n, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Retuns a zero-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid128<T> zeros<T>(N128 n, T t = default)
            where T : unmanaged
                => default;

        /// <summary>
        /// Retuns a zero-filled bitgrid
        /// </summary>
        /// <param name="n">The width selector</param>
        /// <param name="t">The cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitGrid256<T> zeros<T>(N256 n, T t = default)
            where T : unmanaged
                => default;
    }
}
