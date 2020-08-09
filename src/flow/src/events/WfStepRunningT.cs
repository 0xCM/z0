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

    public readonly struct WfStepRunning<T> : IWfEvent<WfStepRunning<T>>
    {
        public const string EventName = nameof(WfStepRunning<T>);
        
        public WfEventId EventId {get;}
        
        public string ActorName {get;}
        
        public T Body {get;}

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(string actor, T body, CorrelationToken ct, AppMsgColor flair = RunningFlair)
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