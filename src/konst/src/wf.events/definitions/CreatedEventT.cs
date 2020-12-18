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
    public readonly struct CreatedEvent<T> : IWfEvent<CreatedEvent<T>>
    {
        public const string EventName = GlobalEvents.Created;

        public WfEventId EventId {get;}

        public EventPayload<T> Content {get;}

        public FlairKind Flair  => FlairKind.Created;

        [MethodImpl(Inline)]
        public CreatedEvent(WfStepId step, T content, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            Content = content;
        }

        public string Format()
            => TextFormatter.format(EventId, Content);
    }
}