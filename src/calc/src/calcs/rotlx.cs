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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotlx128<T> vrotlx<T>(W128 w)
            where T : unmanaged
                => default(VRotlx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotlx256<T> vrotlx<T>(W256 w)
            where T : unmanaged
                => default(VRotlx256<T>);
    }
}