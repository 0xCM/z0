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
    public readonly struct WfWarn<T> : IWfEvent<WfWarn<T>, T>
    {   
        public const string EventName = nameof(WfWarn<T>);             
        
        public WfEventId Id {get;}
        
        public string ActorName {get;}

        public T Body {get;}        
        
        public AppMsgColor Flair {get;}

        public AppMsg Description {get;}
        
        [MethodImpl(Inline)]
        public WfWarn(string actor, T body, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            Body = body;
            ActorName = actor;
            Flair = AppMsgColor.Yellow;
            Description = AppMsg.NoCaller(body, AppMsgKind.Warning);
        }            
        
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);            
    }
}