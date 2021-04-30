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
        [MethodImpl(Inline), Factory(Hi), Closures(Closure)]
        public static VHi128<T> vhi<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VHi128<T>);

        [MethodImpl(Inline), Factory(Hi), Closures(Closure)]
        public static VHi256<T> vhi<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VHi256<T>);
    }
}