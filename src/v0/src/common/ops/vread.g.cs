//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static As;

    partial struct V0
    {
        /// <summary>
        /// Returns a readonly reference to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<T> src)
            where T : unmanaged
                => ref z.vref(ref edit(src));

        /// <summary>
        /// Returns a readonly reference to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<T> src)
            where T : unmanaged
                => ref z.vref(ref edit(src));

        /// <summary>
        /// Returns a readonly reference to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<T> src)
            where T : unmanaged
                => ref z.vref(ref edit(src));

        /// <summary>
        /// Presents a readonly reference to 128-bit S-vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The vector cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T vread<S,T>(in Vector128<S> src)
            where S : unmanaged
                => ref @as<Vector128<S>,T>(ref edit(src));

        /// <summary>
        /// Presents a readonly reference to 256-bit S-vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The vector cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T vread<S,T>(in Vector256<S> src)
            where S : unmanaged
                => ref @as<Vector256<S>,T>(ref edit(src));

        /// <summary>
        /// Presents a readonly reference to 512-bit S-vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The vector cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T vread<S,T>(in Vector512<S> src)
            where S : unmanaged
                => ref @as<Vector512<S>,T>(ref edit(src));
    }
}