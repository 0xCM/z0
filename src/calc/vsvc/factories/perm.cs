//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Reverse), Closures(Integers)]
        public static VReverse128<T> vreverse<T>(N128 w, T t = default)
            where T : unmanaged
                => default(VReverse128<T>);

        [MethodImpl(Inline), Factory(Reverse), Closures(Integers)]
        public static VReverse256<T> vreverse<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VReverse256<T>);

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VSwapHiLo128<T> vswaphl<T>(N128 w, T t = default)
            where T : unmanaged
                => default(VSwapHiLo128<T>);

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VSwapHiLo256<T> vswaphl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSwapHiLo256<T>);
    }
}