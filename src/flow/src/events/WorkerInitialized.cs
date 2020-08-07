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
    using static z;

    [Event]
    public readonly struct WorkerInitialized : IWfEvent<WorkerInitialized>
    {        
        public const string EventName = nameof(WorkerInitialized);        
        
        public WfEventId EventId {get;}
        
        public string ActorName {get;}
        
        public AppMsgColor Flair {get;}
            
        [MethodImpl(Inline)]
        public WorkerInitialized(string worker, CorrelationToken ct, AppMsgColor flair = InitializedFlair)
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