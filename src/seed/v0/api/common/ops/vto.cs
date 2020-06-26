//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
        
    partial struct V0
    {
        /// <summary>
        /// Reinterprets a vector over S-cells as a vector over T-cells
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="t">A target cell type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vto<S,T>(Vector128<S> x, T t = default)
            where S : unmanaged
            where T : unmanaged
                => x.As<S,T>();

        /// <summary>
        /// Reinterprets a vector over S-cells as a vector over T-cells
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="t">A target cell type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vto<S,T>(Vector256<S> x, T t = default)
            where S : unmanaged
            where T : unmanaged
                => x.As<S,T>();

        /// <summary>
        /// Reinterprets a vector over S-cells as a vector over T-cells
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="t">A target cell type representative</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vto<S,T>(Vector512<S> x, T t = default)
            where S : unmanaged
            where T : unmanaged
                => x.As<T>();
    }
}