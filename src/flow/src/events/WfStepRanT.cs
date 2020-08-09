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
    public readonly struct WfStepRan<T> : IWfEvent<WfStepRan<T>, T>
    {
        public const string EventName = nameof(WfStepRan<T>);

        public WfEventId EventId {get;}
                        
        public string ActorName {get;}

        public T Body {get;}

        public AppMsgColor Flair {get;}
        
        [MethodImpl(Inline)]
        public WfStepRan(string actor,  T body, CorrelationToken ct, AppMsgColor flair = RanFlair)
        {            
            EventId = evid(EventName, ct);
            ActorName = actor;
            Body = body;
            Flair = flair;        
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, Body);          
    }   
}