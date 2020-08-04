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
    public readonly struct WorkerFinished : IWfEvent<WorkerFinished>
    {        
        public const string EventName = nameof(WorkerFinished);

        public const AppMsgColor DefaultFlair = AppMsgColor.Cyan;

        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public string ActorName {get;}
        
        [MethodImpl(Inline)]
        public WorkerFinished(string worker, CorrelationToken ct, AppMsgColor flair = DefaultFlair)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, Id, ActorName);
    }
}