//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(EventName)]
    public readonly struct ProcessedEvent<T> : IWfEvent<ProcessedEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Processed;

        public WfEventId EventId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Processed;

        [MethodImpl (Inline)]
        public ProcessedEvent(WfStepId step, T payload, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            Payload = payload;
        }

        [MethodImpl (Inline)]
        public string Format()
            => TextFormatter.format(EventId, Payload);
    }
}