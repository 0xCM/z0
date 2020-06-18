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
        /// Returns a refererence to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T vref<T>(ref Vector128<T> src)
            where T : unmanaged
                => ref Unsafe.As<Vector128<T>,T>(ref src);

        /// <summary>
        /// Returns a refererence to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T vref<T>(ref Vector256<T> src)
            where T : unmanaged
                => ref Unsafe.As<Vector256<T>,T>(ref src);

        /// <summary>
        /// Returns a refererence to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T vref<T>(ref Vector512<T> src)
            where T : unmanaged
                => ref Unsafe.As<Vector512<T>,T>(ref src);
    }
}