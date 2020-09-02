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
    public readonly struct WfStepRan : IWfEvent<WfStepRan>
    {
        public const string EventName = nameof(WfStepRan);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfStepId StepId {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRan(string actor, CorrelationToken ct, MessageFlair flair = Ran)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            StepId = default;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public WfStepRan(WfStepId step, CorrelationToken ct, MessageFlair flair = Ran)
        {
            EventId = evid(EventName, ct);
            Actor = step.Name;
            StepId = step;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public WfStepRan(in WfActor actor, WfStepId step, CorrelationToken ct, MessageFlair flair = Ran)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            StepId = step;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Actor, StepId);
    }
}