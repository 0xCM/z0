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
    public readonly struct BabbleEvent<T> : IWfEvent<BabbleEvent<T>,T>
    {
        public const string EventName = GlobalEvents.Babble;

        public const EventKind Kind = EventKind.Babble;

        public WfEventId EventId {get;}

        public EventPayload<T> Payload {get;}

        public FlairKind Flair => FlairKind.Babble;

        [MethodImpl(Inline)]
        public BabbleEvent(WfStepId step, T data, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            Payload = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, Payload);
    }
}