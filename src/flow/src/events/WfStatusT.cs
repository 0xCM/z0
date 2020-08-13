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
    using static FormatPatterns;
    using static z;

    [Event]
    public readonly struct WfStatus<T> : IWfEvent<WfStatus<T>, T>
    {        
        public const string EventName = nameof(WfStatus<T>);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}        

        public T Body {get;}
        
        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public WfStatus(string actor, T body, CorrelationToken ct, AppMsgColor flair = Status)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            Flair =  flair;
            Body = body;
        }

        [MethodImpl(Inline)]
        public WfStatus(in WfActor actor, T body, CorrelationToken ct, AppMsgColor flair = Status)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            Flair =  flair;
            Body = body;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, Actor, Body);
    }
}