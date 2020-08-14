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
    using static RenderPatterns;
            
    public interface IWfError : IWfEvent
    {
     
    }
    

    [Event]
    public readonly struct WfError<T> : IWfEvent<WfError<T>, T>, IWfError
    {                
        public const string EventName = nameof(WfError<T>);

        public WfEventId EventId {get;}
        
        public WfActor Actor {get;}
        
        public readonly T Data {get;}

        public T Body => Data;
        
        public MessageFlair Flair {get;}
        
        public AppMsgSource Source {get;}

        [MethodImpl(Inline)]
        public WfError(string actor, T body, CorrelationToken ct, AppMsgSource source)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            Data = body;
            Flair =  MessageFlair.Red;
            Source = source;
        }

        [MethodImpl(Inline)]
        public WfError(in WfActor actor, T body, CorrelationToken ct, AppMsgSource source)
        {
            EventId = evid(EventName, ct);
            Actor = actor;
            Data = body;
            Flair =  MessageFlair.Red;
            Source = source;
        }
        public string Format()
            => text.format(PSx4, EventId, Actor, Source, Data);
    }
}