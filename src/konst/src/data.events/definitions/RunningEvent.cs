//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    [Event]
    public readonly struct RunningEvent : IWfEvent<RunningEvent>
    {
        public const string EventName = nameof(GlobalEvents.Running);

        public WfEventId EventId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RunningEvent(WfStepId step, CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = (EventName, step, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}