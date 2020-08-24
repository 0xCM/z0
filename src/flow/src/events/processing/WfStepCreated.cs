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
    using static Flow;
    using static z;

    public readonly struct WfStepCreated : IWfEvent<WfStepCreated>
    {
        public const string EventName = nameof(WfStepCreated);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfStepId StepId {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfStepCreated(WfStepId id, CorrelationToken ct, MessageFlair flair = MessageFlair.Magenta)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = WfActor.create();
            StepId = id;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public WfStepCreated(Type host, CorrelationToken ct, MessageFlair flair = MessageFlair.Magenta)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = WfActor.create();
            StepId = AB.step(host);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public WfStepCreated(in WfActor actor, WfStepId id, CorrelationToken ct, MessageFlair flair = MessageFlair.Magenta)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = actor;
            StepId = id;
            Flair = flair;
        }

        public string Format()
            => format(EventId, Actor, StepId);
    }
}