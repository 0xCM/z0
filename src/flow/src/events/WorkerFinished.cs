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
    using static WorkerFinishedEvent;

    [Event(true)]
    public readonly struct WorkerFinishedEvent
    {
        public const string EventName = nameof(WorkerFinished);

        public const string Pattern = IdMarker + "Finished";

        public const AppMsgColor DefaultFlair = AppMsgColor.Cyan;
    }

    [Event]
    public readonly struct WorkerFinished : IWfEvent<WorkerFinished>
    {        
        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public string WorkerName {get;}
        
        [MethodImpl(Inline)]
        public WorkerFinished(string worker, CorrelationToken ct, AppMsgColor flair = DefaultFlair)
        {
            WorkerName = worker;
            Id = wfid(worker, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id);
    }
}