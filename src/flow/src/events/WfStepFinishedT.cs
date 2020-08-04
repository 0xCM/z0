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

        public WfEventId Id {get;}
                        
        public string ActorName {get;}

        public T Body {get;}

        public AppMsgColor Flair {get;}

        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public WfStepFinished(string worker, T body, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Cyan)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Body = body;
            Flair = flair;
            Description = AppMsg.Colorize(Body, Flair);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);          
    }   
}