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
    public readonly struct WfError<T> : IWfEvent<WfError<T>, T>
    {                
        public const string EventName = nameof(WfError<T>);

        public WfEventId Id {get;}
        
        public string ActorName {get;}
        
        public readonly T Body {get;}

        public AppMsgColor Flair {get;}

        public AppMsg Description {get;}
        
        [MethodImpl(Inline)]
        public WfError(string actor, T body, AppMsg description, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = actor;
            Body = body;
            Flair =  AppMsgColor.Red;
            Description = description;
        }

        [MethodImpl(Inline)]
        public WfError(string worker, T body, Exception e, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Body = body;
            Flair =  AppMsgColor.Red;
            Description = AppMsg.Colorize(text.concat(body, e), ErrorColor, AppMsgKind.Error);
        }

        [MethodImpl(Inline)]
        public WfError(string worker, T body, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Body = body;
            Flair =  AppMsgColor.Red;
            Description = AppMsg.NoCaller(Body, AppMsgKind.Error);
        }
              
        public string Format()
            => text.format(PSx3, Id, ActorName, Body);
    }
}