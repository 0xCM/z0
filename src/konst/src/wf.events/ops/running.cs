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
        [MethodImpl(Inline), Op]
        public static StatusEvent<string> running(WfStepId step, CorrelationToken ct)
            => new StatusEvent<string>(step, GlobalEvents.Running, ct);

        [MethodImpl(Inline)]
        public static RunningEvent<T> running<T>(WfHost host, string operation, T data, CorrelationToken ct)
            => new RunningEvent<T>(host, operation, data, ct);

        [MethodImpl(Inline)]
        public static StatusEvent<T> running<H,T>(H host, T data, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new StatusEvent<T>(host.Id, GlobalEvents.Running, data, ct);
    }
}