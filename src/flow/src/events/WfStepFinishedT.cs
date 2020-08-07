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
    public readonly struct WfStepFinished<T> : IWfEvent<WfStepFinished<T>, T>
    {
        public const string EventName = nameof(WfStepFinished<T>);

        public WfEventId EventId {get;}
                        
        public string ActorName {get;}

        public T Body {get;}

        public AppMsgColor Flair {get;}
        
        [MethodImpl(Inline)]
        public WfStepFinished(string worker, T body, CorrelationToken ct, AppMsgColor flair = FinishedFlair)
        {
            EventId = wfid(EventName, ct);
            ActorName = worker;
            Body = body;
            Flair = flair;        
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, ActorName, Body);          
    }   
}