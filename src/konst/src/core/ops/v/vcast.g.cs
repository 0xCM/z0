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

    partial struct z
    {        
        /// <summary>
        /// Presents a 128-bit S-cell vector as a 128-bit T-cell vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="t">A target cell representative used only for type inference</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vcast<S,T>(Vector128<S> x, T t = default)
            where S : unmanaged
            where T : unmanaged
                => x.As<S,T>();

        /// <summary>
        /// Presents a 256-bit S-cell vector as a 256-bit T-cell vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="t">A target cell representative used only for type inference</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vcast<S,T>(Vector256<S> x, T t = default)
            where S : unmanaged
            where T : unmanaged
                => x.As<S,T>();

        /// <summary>
        /// Presents a 512-bit S-cell vector as a 512-bit T-cell vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="t">A target cell representative used only for type inference</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vcast<S,T>(Vector512<S> x, T t = default)
            where S : unmanaged
            where T : unmanaged
                => x.As<T>();
    }
}