//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Copies a reference-identified cell to a pointer-identified target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="pDst">The target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy<T>(in T src, void* pDst)
            => Unsafe.Copy(pDst, ref Unsafe.AsRef(src));   

        /// <summary>
        /// Copies a reference-identified cell to a pointer-identified target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="pDst">The target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy<T>(in T src, T* pDst)
            where T : unmanaged
                => Unsafe.Copy(pDst, ref Unsafe.AsRef(src));   
    }
}