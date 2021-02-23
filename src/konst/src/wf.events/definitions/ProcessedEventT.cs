//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public readonly struct ProcessedEvent<T> : IWfEvent<ProcessedEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Processed;

        public const EventKind Kind = EventKind.Processed;

        public WfEventId EventId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Processed;

        [MethodImpl (Inline)]
        public ProcessedEvent(WfStepId step, T payload, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            Payload = payload;
        }

        [MethodImpl (Inline)]
        public string Format()
            => TextFormatter.format(EventId, Payload);
    }
}