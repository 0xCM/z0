//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    using static FormatPatterns;

    public readonly struct WfStepCreated : IWfEvent<WfStepCreated>
    {
        public const string EventName = nameof(WfStepCreated);

        public WfEventId EventId {get;}
                
        public WfActor Actor {get;}
        
        public WfStepId StepId {get;}

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepCreated(WfStepId id, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Magenta)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = WfActor.create();
            StepId = id;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public WfStepCreated(Type step, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Magenta)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = WfActor.create();
            StepId = Flow.step(step);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public WfStepCreated(in WfActor actor, WfStepId id, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Magenta)
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