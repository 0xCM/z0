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
    using static z;
    [Event]
    public readonly struct WfStatus<T> : IWfEvent<WfStatus<T>, T>
    {        
        public const string EventName = nameof(WfStatus<T>);

        public WfEventId Id {get;}

        public string ActorName {get;}        

        public T Body {get;}

        public AppMsgColor Flair {get;}

        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public WfStatus(string worker, T body, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Blue)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Flair =  flair;
            Body = body;
            Description = AppMsg.Colorize(Body, Flair);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);
    }
}