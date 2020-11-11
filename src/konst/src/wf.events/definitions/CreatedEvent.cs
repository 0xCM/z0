//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Event(EventName)]
    public readonly struct CreatedEvent : IWfEvent<CreatedEvent>
    {
        public const string EventName = GlobalEvents.Created;

        public WfEventId EventId {get;}

        public FlairKind Flair => FlairKind.Created;

        [MethodImpl(Inline)]
        public CreatedEvent(WfStepId step, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}