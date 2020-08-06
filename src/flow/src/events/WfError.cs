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
    public readonly struct WfError : IWfEvent<WfError, object>
    {                
        public const string EventName = nameof(WfError);
        
        public WfEventId Id {get;}
        
        public string ActorName {get;}

        public object Body {get;}
        
        public AppMsgColor Flair {get;}
                        
        [MethodImpl(Inline)]
        public WfError(string actor, object body, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = actor;
            Body = body;
            Flair = AppMsgColor.Red;            
        }
                
        public string Format()
            => text.format(PSx3, Id, ActorName, Body);
    }
}