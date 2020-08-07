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
            
    public interface IWfError : IWfEvent
    {
        object Description {get;}   
    }
    
    [Event]
    public readonly struct WfError<T> : IWfError, IWfEvent<WfError<T>, T>
    {                
        public const string EventName = nameof(WfError<T>);

        public WfEventId EventId {get;}
        
        public string ActorName {get;}
        
        public readonly T Body {get;}

        public AppMsgColor Flair {get;}
        
        public AppMsgSource Source {get;}

        [MethodImpl(Inline)]
        public WfError(string actor, T body, CorrelationToken ct, AppMsgSource source)
        {
            EventId = wfid(EventName, ct);
            ActorName = actor;
            Body = body;
            Flair =  AppMsgColor.Red;
            Source = source;
        }

        public object Description => new {EventId, ActorName, Source, Body};
              
        public string Format()
            => text.format(PSx4, EventId, ActorName, Source, Body);
    }
}