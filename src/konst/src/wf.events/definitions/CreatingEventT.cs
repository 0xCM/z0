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
    public readonly struct CreatingEvent<T> : IWfEvent<CreatingEvent<T>>
    {
        public const string EventName = GlobalEvents.Creating;

        public const EventKind Kind = EventKind.Creating;

        public WfEventId EventId {get;}

        public EventPayload<T> Content {get;}

        public FlairKind Flair => FlairKind.Creating;

        [MethodImpl(Inline)]
        public CreatingEvent(WfStepId step, T content, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            Content = content;
        }

        public string Format()
            => TextFormatter.format(EventId, Content);
    }
}