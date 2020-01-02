//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Operator factory for veq_128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static LoadSpan128<T> vloadspan<T>(N128 w, T t = default)
            where T : unmanaged
                => LoadSpan128<T>.Op;

        /// <summary>
        /// Operator factory for veq_256xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static LoadSpan256<T> vloadspan<T>(N256 w, T t = default)
            where T : unmanaged
                => LoadSpan256<T>.Op;
    }
}