//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct WfEvents
    {

        [MethodImpl(Inline)]
        public static RanEvent<T> ran<H,T>(H host, T data, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new RanEvent<T>(host.Id, data, ct);
    }
}