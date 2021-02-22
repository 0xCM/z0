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
        [MethodImpl(Inline), Op]
        public static RunningEvent running(WfStepId step, CorrelationToken ct)
            => new RunningEvent(step, ct);

        [MethodImpl(Inline)]
        public static RunningEvent<T> running<T>(WfHost host, string operation, T    data, CorrelationToken ct)
            => new RunningEvent<T>(host, operation, data, ct);

        [MethodImpl(Inline)]
        public static RunningEvent<T> running<H,T>(H host, T data, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new RunningEvent<T>(host.Id, data, ct);
    }
}