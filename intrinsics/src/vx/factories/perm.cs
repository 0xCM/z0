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
        /// Operator factory for vinc_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Reverse128<T> vreverse<T>(N128 w, T t = default)
            where T : unmanaged
                => Reverse128<T>.Op;

        /// <summary>
        /// Operator factory for vinc_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Reverse256<T> vreverse<T>(N256 w, T t = default)
            where T : unmanaged
                => Reverse256<T>.Op;
    }
}