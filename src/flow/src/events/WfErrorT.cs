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
        
        [MethodImpl(Inline)]
        public WfError(string worker, T body, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Body = body;
            Flair =  AppMsgColor.Red;
        }
              
        public string Format()
            => text.format(PSx3, Id, ActorName, Body);
    }
}