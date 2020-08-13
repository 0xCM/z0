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

    [Event]
    public readonly struct WfStepRunning : IWfEvent<WfStepRunning>
    {        
        public const string EventName = nameof(WfStepRunning);

        public WfEventId EventId {get;}
    
        public WfActor Actor {get;}

        public WfStepId Step {get;}
        
        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(WfActor actor, WfStepId step, CorrelationToken ct, AppMsgColor flair = Running)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            Step = step;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Actor, Step);
    }
}