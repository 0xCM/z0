//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.IO;
    using System.Runtime.CompilerServices;
    using System;

    using static Konst;
    using static RP;
    using static z;

    partial struct WfEvents
    {
        [Event]
        public readonly struct Initializing : IWfEvent<Initializing>
        {
            public const string EventName = nameof(Initializing);

            public WfEventId EventId { get; }

            public WfStepId StepId { get; }

            public FlairKind Flair { get; }

            [MethodImpl (Inline)]
            public Initializing(WfStepId worker, CorrelationToken ct, FlairKind flair = Render.Initializing)
            {
                EventId = evid (EventName, ct);
                StepId = worker;
                Flair = flair;
            }

            [MethodImpl (Inline)]
            public string Format()
                => text.format(PSx2, EventId, StepId);
        }
    }
}