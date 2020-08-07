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
    public readonly struct OpeningWfContext : IWfEvent<OpeningWfContext, string>
    {
        public const string EventName = nameof(OpeningWfContext);

        public const string Pattern = "Opening workflow context | {0}";
        
        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public string Body {get;}
        
        public AppMsgColor Flair {get;}
                
        [MethodImpl(Inline)]
        public OpeningWfContext(string worker, string type, CorrelationToken ct, AppMsgColor flair = CreatedFlair)
        {
            EventId = wfid(EventName, ct);
            ActorName = worker;
            Body = type;
            Flair = flair;            
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, Body);        
    }
}