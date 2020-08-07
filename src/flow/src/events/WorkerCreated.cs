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
    public readonly struct WorkerCreated : IWfEvent<WorkerCreated>
    {        
        public const string EventName = nameof(WorkerCreated);        

        public WfEventId EventId {get;}

        public AppMsgColor Flair {get;}

        public string ActorName {get;}
        
        [MethodImpl(Inline)]
        public WorkerCreated(string worker, CorrelationToken ct, AppMsgColor flair = CreatedFlair)
        {
            EventId = wfid(EventName, ct);
            ActorName = worker;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, EventId, ActorName);
    }
}