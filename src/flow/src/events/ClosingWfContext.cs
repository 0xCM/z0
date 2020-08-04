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
                
        public WfEventId Id {get;}

        public string ActorName {get;}
        
        public string Body {get;}

        public AppMsgColor Flair {get;}
        
        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public ClosingWfContext(string worker, string type, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Blue)
        {
            Id = wfid(EventName, ct);
            Body = type;
            ActorName = worker;
            Flair = flair;
            Description = AppMsg.Colorize(text.format(EventMsg, Body), Flair);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);        
    }
}