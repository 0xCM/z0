//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct WfEvents
    {
        public readonly struct Initialized : IWfEvent<Initialized>
        {
            public const string EventName = nameof(Initialized);

            public WfEventId EventId {get;}

            public WfStepId StepId {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public Initialized(WfStepId step, CorrelationToken ct, FlairKind flair = Render.Initialized)
            {
                EventId = (EventName, step, ct);
                StepId = step;
                Flair = flair;
            }

            [MethodImpl (Inline)]
            public string Format()
                => EventId.Format();
        }
    }
}