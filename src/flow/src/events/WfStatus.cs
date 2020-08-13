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
    using static FormatPatterns;
    using static z;
    
    [Event]
    public readonly struct WfStatus : IWfEvent<WfStatus, string>
    {        
        public const string EventName = nameof(WfStatus);        

        public WfEventId EventId {get;}
    
        public string ActorName {get;}

        public string Body {get;}
        
        public AppMsgColor Flair {get;}

        public AppMsg Description {get;}
 
        [MethodImpl(Inline)]
        public WfStatus(string actor, string body, CorrelationToken ct, AppMsgColor flair = Status)
        {
            EventId = evid(EventName, ct);
            ActorName = actor;
            Body = body;
            Flair =  flair;
            Description = AppMsg.Colorize(Body, Flair);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, Description);
    }
}