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
    using static WorkerCreatedEvent;

    [Event(true)]
    public readonly struct WorkerCreatedEvent
    {
        public const string EventName = nameof(WorkerCreated);
        
        public const string Pattern = IdMarker + "Created";

        public const AppMsgColor DefaultFlair = AppMsgColor.Magenta;
    }

    [Event]
    public readonly struct WorkerCreated : IWfEvent<WorkerCreated>
    {        
        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public string WorkerName {get;}
        
        [MethodImpl(Inline)]
        public WorkerCreated(string worker, CorrelationToken ct, AppMsgColor flair = DefaultFlair)
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