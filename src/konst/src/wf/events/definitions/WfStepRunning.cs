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
    public readonly struct WfStepRunning : IWfEvent<WfStepRunning>
    {
        public const string EventName = nameof(WfStepRunning);

        public WfEventId EventId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(WfStepId step, CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = (EventName, step, ct);
            Flair = flair;
        }


        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}