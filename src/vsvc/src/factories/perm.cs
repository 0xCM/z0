//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static VServices;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Reverse128<T> vreverse<T>(N128 w, T t = default)
            where T : unmanaged
                => default(Reverse128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Reverse256<T> vreverse<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Reverse256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SwapHiLo128<T> vswaphl<T>(N128 w, T t = default)
            where T : unmanaged
                => default(SwapHiLo128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SwapHiLo256<T> vswaphl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(SwapHiLo256<T>);
    }
}