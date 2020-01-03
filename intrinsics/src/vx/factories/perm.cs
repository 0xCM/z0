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
        [MethodImpl(Inline)]
        public static Reverse128<T> vreverse<T>(N128 w, T t = default)
            where T : unmanaged
                => Reverse128<T>.Op;

        [MethodImpl(Inline)]
        public static Reverse256<T> vreverse<T>(N256 w, T t = default)
            where T : unmanaged
                => Reverse256<T>.Op;

        [MethodImpl(Inline)]
        public static SwapHiLo128<T> vswaphl<T>(N128 w, T t = default)
            where T : unmanaged
                => SwapHiLo128<T>.Op;

        [MethodImpl(Inline)]
        public static SwapHiLo256<T> vswaphl<T>(N256 w, T t = default)
            where T : unmanaged
                => SwapHiLo256<T>.Op;
    }
}