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

    [Event(EventName)]
    public readonly struct EmittedHostBytesEvent : IWfEvent<EmittedHostBytesEvent>
    {
        public const string EventName = "EmittedHostBytes";

        public WfEventId EventId {get;}

        public ApiHostUri Host {get;}

        public Count AccessorCount {get;}

        public FlairKind Flair {get;}


        [MethodImpl(Inline)]
        public EmittedHostBytesEvent(WfStepId step, ApiHostUri host, ushort count, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName,step,ct);
            Host= host;
            AccessorCount = count;
            Flair = flair;
        }

        public string Format()
            => format(EventId, Host, AccessorCount);
    }
}