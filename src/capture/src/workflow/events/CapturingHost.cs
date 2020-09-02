//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event]
    public readonly struct CapturingHost : IWfEvent<CapturingHost>
    {
        public const string EventName = nameof(CapturingHost);

        public WfEventId EventId {get;}

        public readonly ApiHostUri Host;

        [MethodImpl(Inline)]
        public CapturingHost(ApiHostUri host, CorrelationToken ct)
        {
            EventId = z.evid(EventName, ct);
            Host = host;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Host);
    }
}