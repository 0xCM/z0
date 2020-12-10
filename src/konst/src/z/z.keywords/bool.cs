//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline), TestBit]
        public static unsafe bool @bool(BitState src)
            => memory.@bool(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref bool @bool<T>(in T src)
            => ref memory.@bool(src);
    }
}