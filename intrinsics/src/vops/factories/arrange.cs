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

    using static VOpTypes;

    partial class VOps
    {
        /// <summary>
        /// Operator factory for vconcat_2x128xT
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Concat2x128<T> vconcat<T>(N128 w, T t = default)
            where T : unmanaged
                => Concat2x128<T>.Op;
    }
}