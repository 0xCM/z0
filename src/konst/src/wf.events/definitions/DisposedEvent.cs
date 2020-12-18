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
    public readonly struct DisposedEvent : IWfEvent<DisposedEvent>
    {
        public const string EventName = GlobalEvents.Disposed;

        public WfEventId EventId {get;}

        public FlairKind Flair => FlairKind.Disposed;

        [MethodImpl(Inline)]
        public DisposedEvent(WfStepId step, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
        }

        public string Format()
            => EventId.Format();
    }
}