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
    public readonly struct WfStepRunning : IWfEvent<WfStepRunning, string>
    {        
        public const string EventName = nameof(WfStepRunning);

        public WfEventId Id {get;}
    
        public string ActorName {get;}

        public string Body {get;}

        public AppMsgColor Flair {get;}

        public AppMsg Description {get;}

        [MethodImpl(Inline)]
        public WfStepRunning(string worker, CorrelationToken ct, AppMsgColor flair = RunningFlair)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Body = "Running";
            Flair = flair;
            Description = AppMsg.Colorize(Body, Flair);
        }

        [MethodImpl(Inline)]
        public WfStepRunning(string worker, string body, CorrelationToken ct, AppMsgColor flair = RunningFlair)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Body = body;
            Flair = flair;
            Description = AppMsg.Colorize(body, Flair);
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);
    }
}