//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct gcpu
    {
        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vset<T>(Vector128<T> src, byte index, T value)
            where T : unmanaged
                => src.WithElement(index,value);

        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vset<T>(T src, byte index, Vector128<T> dst)
            where T : unmanaged
                => dst.WithElement(index, src);

        /// <summary>
        /// Sets an index-identified component to a specified value
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index of the component to extract</param>
        /// <param name="value">The new component value</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vset<T>(T src, byte index, Vector256<T> dst)
            where T : unmanaged
                => dst.WithElement(index, src);
    }
}