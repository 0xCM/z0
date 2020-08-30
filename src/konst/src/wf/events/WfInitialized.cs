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
    using static Render;
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WfInitialized : IWfEvent<WfInitialized>
    {
        public const string EventName = nameof(WfInitialized);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfInitialized(WfStepId worker, CorrelationToken ct, MessageFlair flair = Initialized)
        {
            EventId = evid(EventName, ct);
            StepId = worker;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, EventId, StepId);
    }
}