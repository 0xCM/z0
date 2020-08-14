//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<MemoryAddress> addresses(Type declarer)
            => LiteralFieldApi.values<string>(declarer).Map(Resources.address);
    }
}