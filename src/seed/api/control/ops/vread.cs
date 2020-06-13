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

    partial class Control
    {
        /// <summary>
        /// Returns a readonly refererence to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<T> src)
            where T : unmanaged
                => ref vref(ref edit(src));

        /// <summary>
        /// Returns a readonly refererence to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<T> src)
            where T : unmanaged
                => ref vref(ref edit(src));

        /// <summary>
        /// Returns a readonly refererence to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<T> src)
            where T : unmanaged
                => ref vref(ref edit(src));
    }
}