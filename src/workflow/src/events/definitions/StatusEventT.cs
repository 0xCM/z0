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
    public readonly struct StatusEvent<T> : IWfEvent<StatusEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Status;

        public const EventKind Kind = EventKind.Status;

        public WfEventId EventId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Status;

        [MethodImpl(Inline)]
        public StatusEvent(WfStepId step, T data, CorrelationToken ct = default)
        {
            EventId = WfEventId.define(EventName, step);
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(EventId, Payload);
    }
}