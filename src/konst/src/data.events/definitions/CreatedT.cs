//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [Event(EventName)]
    public readonly struct CreatedEvent<T> : IWfEvent<CreatedEvent<T>>
    {
        public const string EventName = nameof(GlobalEvents.Created);

        public WfEventId EventId {get;}

        public EventPayload<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public CreatedEvent(WfStepId step, T content, CorrelationToken ct, FlairKind flair = FlairKind.Created)
        {
            EventId = (EventName, step, ct);
            Content = content;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Content);
    }
}