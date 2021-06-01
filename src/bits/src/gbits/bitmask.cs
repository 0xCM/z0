//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class gbits
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitMask<T> bitmask<T>(T invariant)
            where T : unmanaged
                => new BitMask<T>(invariant);
    }
}