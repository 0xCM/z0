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

    partial struct Calcs
    {
        [MethodImpl(Inline)]
        public static VBitClear128<T> vbitclear<T>(N128 w)
            where T : unmanaged
                => default(VBitClear128<T>);

        [MethodImpl(Inline)]
        public static VBitClear256<T> vbitclear<T>(N256 w)
            where T : unmanaged
                => default(VBitClear256<T>);
    }
}