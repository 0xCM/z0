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
    using static memory;
    using static SFx;
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Rotrx), Closures(Closure)]
        public static VRotrx128<T> vrotrx<T>(W128 w)
            where T : unmanaged
                => default(VRotrx128<T>);

        [MethodImpl(Inline), Factory(Rotrx), Closures(Closure)]
        public static VRotrx256<T> vrotrx<T>(W256 w)
            where T : unmanaged
                => default(VRotrx256<T>);
    }
}