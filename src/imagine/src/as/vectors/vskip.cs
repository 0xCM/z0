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

    partial struct As
    {        
        /// <summary>
        /// Returns a reference to an index-identified T-cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The cell index</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T vskip<T>(in Vector128<T> src, byte index)
            where T : unmanaged
                => ref add(vfirst(src), index);

        /// <summary>
        /// Returns a reference to an index-identified T-cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The cell index</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T vskip<T>(in Vector256<T> src, byte index)
            where T : unmanaged
                => ref add(vfirst(src), index);                

        /// <summary>
        /// Returns a readonly reference to an index-identified T-cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The cell index</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T vskip<T>(in Vector512<T> src, byte index)
            where T : unmanaged
                => ref add(vfirst(src), index);                
    }
}