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
    public class ProcessedEvent<T> : IWfEvent<ProcessedEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Processed;

        public const EventKind Kind = EventKind.Processed;

        public WfEventId EventId {get;}

        public EventPayload<T> Payload {get;}

        public ProcessedEvent()
        {
            EventId = WfEventId.Empty;
            Payload = EventPayload<T>.Empty;
        }


        [MethodImpl (Inline)]
        public ProcessedEvent(WfStepId step, T payload, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            Payload = payload;
        }

        public FlairKind Flair => FlairKind.Processed;

        [MethodImpl (Inline)]
        public string Format()
            => text.format(EventId, Payload);
    }
}