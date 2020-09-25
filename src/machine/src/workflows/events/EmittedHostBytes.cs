//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    [Event]
    public readonly struct EmittedHostBytes : IWfEvent<EmittedHostBytes>
    {
        public const string EventName = nameof(EmittedHostBytes);

        public WfEventId EventId {get;}

        public ApiHostUri Host {get;}

        public Count AccessorCount {get;}

        [MethodImpl(Inline)]
        public EmittedHostBytes(WfStepId step, ApiHostUri host, ushort count, CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = (EventName,step,ct);
            Host= host;
            AccessorCount = count;
        }

        public string Format()
            => format(EventId, Host, AccessorCount);
    }
}