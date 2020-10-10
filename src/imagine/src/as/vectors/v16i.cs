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

    partial struct AsDeprecated
    {
        /// <summary>
        /// Presents a vector over T-cells as a vector over cells of type int16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<short> v16i<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsInt16();

        /// <summary>
        /// Presents a vector over T-cells as a vector over cells of type int16
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<short> v16i<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsInt16();
    }
}