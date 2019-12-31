//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static VXTypes;

    partial class VX
    {
        /// <summary>
        /// Operator factory for vones_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Ones128<T> vones<T>(N128 w, T t = default)
            where T : unmanaged
                => Ones128<T>.Op;

        /// <summary>
        /// Operator factory for vones_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Ones256<T> vones<T>(N256 w, T t = default)
            where T : unmanaged
                => Ones256<T>.Op;

        /// <summary>
        /// Operator factory for vones_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Units128<T> vunits<T>(N128 w, T t = default)
            where T : unmanaged
                => Units128<T>.Op;

        /// <summary>
        /// Operator factory for vones_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Units256<T> vunits<T>(N256 w, T t = default)
            where T : unmanaged
                => Units256<T>.Op;
    }
}