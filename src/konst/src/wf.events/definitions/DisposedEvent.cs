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
    public readonly struct DisposedEvent : IWfEvent<DisposedEvent>
    {
        public const string EventName = nameof(GlobalEvents.Disposed);

        public WfEventId EventId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public DisposedEvent(WfStepId step, CorrelationToken ct, FlairKind flair = Render.Disposed)
        {
            EventId = (EventName, step, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}