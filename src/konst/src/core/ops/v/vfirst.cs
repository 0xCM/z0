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
        /// Returns a refernce to the leading cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector128<T> src)
            where T : unmanaged
                => ref @as<Vector128<T>,T>(src);

        /// <summary>
        /// Returns a refernce to the leading cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector256<T> src)
            where T : unmanaged
                => ref @as<Vector256<T>,T>(src);

        /// <summary>
        /// Returns a refernce to the leading cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector512<T> src)
            where T : unmanaged
                => ref @as<Vector512<T>,T>(src);
    }
}