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

    partial class Vectors
    {
        /// <summary>
        /// Loads a 128-bit vector from a pointer-identified memory location
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="pSrc">The source memory location</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Vector128<T> vload<T>(W128 w, T* pSrc)
            where T : unmanaged
                => VStore.vload(w, pSrc);
        
        /// <summary>
        /// Loads a 256-bit vector from a pointer-identified memory location
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="pSrc">The source memory location</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Vector256<T> vload<T>(W256 w, T* pSrc)
            where T : unmanaged
                => VStore.vload(w, pSrc);

        /// <summary>
        /// Loads a 512-bit vector from a pointer-identified memory location
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="pSrc">The source memory location</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Vector512<T> vload<T>(W512 w, T* pSrc)
            where T : unmanaged
                => VStore.vload(w, pSrc);

        /// <summary>
        /// Loads a 128-bit vector from a pointer-identified memory location
        /// </summary>
        /// <param name="pSrc">The source memory location</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe ref Vector128<T> vload<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
                => ref VStore.vload(pSrc, out dst);

        /// <summary>
        /// Loads a 256-bit vector from a pointer-identified memory location
        /// </summary>
        /// <param name="pSrc">The source memory location</param>
        /// <param name="dst">The target vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe ref Vector256<T> vload<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
                => ref VStore.vload(pSrc, out dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe ref Vector512<T> vload<T>(T* pSrc, out Vector512<T> dst)
            where T : unmanaged
                => ref VStore.vload(pSrc, out dst);
    }
}