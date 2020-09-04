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

    public readonly struct WfStepCreated : IWfEvent<WfStepCreated>
    {
        public const string EventName = nameof(WfStepCreated);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfStepCreated(WfStepId step, CorrelationToken ct, FlairKind flair = Created)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}