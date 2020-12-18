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
    public readonly struct RunningEvent : IWfEvent<RunningEvent>
    {
        public const string EventName = GlobalEvents.Running;

        public WfEventId EventId {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public RunningEvent(WfStepId step, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}