//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static Reverse128<T> vreverse<T>(N128 w, T t = default)
            where T : unmanaged
                => default(Reverse128<T>);

        [MethodImpl(Inline)]
        public static Reverse256<T> vreverse<T>(N256 w, T t = default)
            where T : unmanaged
                => default(Reverse256<T>);

        [MethodImpl(Inline)]
        public static SwapHiLo128<T> vswaphl<T>(N128 w, T t = default)
            where T : unmanaged
                => default(SwapHiLo128<T>);

        [MethodImpl(Inline)]
        public static SwapHiLo256<T> vswaphl<T>(N256 w, T t = default)
            where T : unmanaged
                => default(SwapHiLo256<T>);
    }
}