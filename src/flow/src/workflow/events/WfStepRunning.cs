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
    
        public WfActor Actor {get;}

        public WfStepId Step {get;}
        
        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(WfActor actor, WfStepId step, CorrelationToken ct, MessageFlair flair = Flow.Running)
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