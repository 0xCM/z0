//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public static class CoreRng
    {
        [MethodImpl(Inline)]
        public static IRngStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                => RandomStream.From(src,rng);
    }
}