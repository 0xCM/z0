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
        
        public WfEventId EventId {get;}
        
        public string ActorName {get;}

        public T Body {get;}        
        
        public AppMsgColor Flair {get;}
        
        [MethodImpl(Inline)]
        public WfWarn(string actor, T body, CorrelationToken ct)
        {
            EventId = wfid(EventName, ct);
            Body = body;
            ActorName = actor;
            Flair = AppMsgColor.Yellow;
        }                    
        public string Format()
            => text.format(PSx3, EventId, ActorName, Body);            
    }
}