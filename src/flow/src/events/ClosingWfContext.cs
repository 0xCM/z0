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
    public readonly struct ClosingWfContext : IWfEvent<ClosingWfContext, string>
    {
        public const string EventName = nameof(ClosingWfContext);

        public const string EventMsg = "Closing workflow context | {0}";
                
        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public string Body {get;}

        public AppMsgColor Flair {get;}
        
        [MethodImpl(Inline)]
        public ClosingWfContext(string actor, string type, CorrelationToken ct, AppMsgColor flair = FinishedFlair)
        {
            EventId = wfid(EventName, ct);
            Body = type;
            ActorName = actor;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, Body);        
    }
}