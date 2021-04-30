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
        [MethodImpl(Inline), Factory(Dist), Closures(AllNumeric)]
        public static Dist<T> dist<T>()
            where T : unmanaged
                => default;
    }
}