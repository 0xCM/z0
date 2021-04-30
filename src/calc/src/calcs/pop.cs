//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static CalcHosts;
    using static SFx;
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Pop), Closures(Integers)]
        public static PopCount<T> pop<T>()
            where T : unmanaged
                => sfunc<PopCount<T>>();
    }
}