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
    using static Flow;

    [Event]
    public readonly struct WfStepRan : IWfEvent<WfStepRan>
    {
        public const string EventName = nameof(WfStepRan);

        public WfEventId EventId {get;}
                        
        public WfStepId StepId {get;}

        public string ActorName {get;}        

        public AppMsgColor Flair {get;}
        
        [MethodImpl(Inline)]
        public WfStepRan(string worker, CorrelationToken ct, AppMsgColor flair = RanFlair)
        {
            StepId = default;
            EventId = evid(EventName, ct);
            ActorName = worker;
            Flair = flair;        
        }

        [MethodImpl(Inline)]
        public WfStepRan(WfStepId step, CorrelationToken ct, AppMsgColor flair = RanFlair)
        {
            EventId = evid(EventName, ct);
            ActorName = step.Name;
            Flair = flair;    
            StepId = step;    
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName);          
    }   
}