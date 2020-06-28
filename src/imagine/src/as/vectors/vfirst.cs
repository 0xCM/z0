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
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {        
        /// <summary>
        /// Returns a refernce to the leading cell of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector128<T> src)
            where T : unmanaged
                => ref As<Vector128<T>,T>(ref edit(src));

        /// <summary>
        /// Returns a refernce to the leading cell of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector256<T> src)
            where T : unmanaged
                => ref As<Vector256<T>,T>(ref edit(src));

        /// <summary>
        /// Returns a refernce to the leading cell of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector512<T> src)
            where T : unmanaged
                => ref As<Vector512<T>,T>(ref edit(src));
    }
}