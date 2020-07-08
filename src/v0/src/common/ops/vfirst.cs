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
        /// Returns a reference to the leading cell of the data source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector128<T> src)        
            where T : unmanaged
                => ref core.@as<Vector128<T>,T>(src);

        /// <summary>
        /// Returns a reference to the leading cell of the data source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector256<T> src)        
            where T : unmanaged
                => ref core.@as<Vector256<T>,T>(src);

        /// <summary>
        /// Returns a reference to the leading cell of the data source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T vfirst<T>(in Vector512<T> src)        
            where T : unmanaged
                => ref core.@as<Vector512<T>,T>(src);
    }
}