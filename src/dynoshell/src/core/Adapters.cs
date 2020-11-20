//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Adapters
    {
        [MethodImpl(Inline)]
        public static Adapter<H,S> adapt<H,S>(S subject)
            where H : IAdapter<H,S>, new()
                => new Adapter<H,S>(subject);
    }
}