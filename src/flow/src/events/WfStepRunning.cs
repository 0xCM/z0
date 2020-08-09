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
    
        public string ActorName {get;}

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(string actor, CorrelationToken ct, AppMsgColor flair = RunningFlair)
        {
            EventId = evid(EventName, ct);
            ActorName = actor;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, EventId, ActorName);
    }
}