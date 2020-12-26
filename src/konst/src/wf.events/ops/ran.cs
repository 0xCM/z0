//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEvents
    {
        [MethodImpl(Inline)]
        public static StatusEvent<T> ran<H,T>(H host, T data, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new StatusEvent<T>(host.Id, GlobalEvents.Ran, data, ct);

        [MethodImpl(Inline), Op]
        public static StatusEvent<string> ran(WfStepId step, CorrelationToken ct)
            => new StatusEvent<string>(step, GlobalEvents.Ran, ct);
    }
}