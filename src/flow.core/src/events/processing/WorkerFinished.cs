//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Render;    
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WorkerFinished : IWfEvent<WorkerFinished>
    {        
        public const string EventName = nameof(WorkerFinished);

        public WfEventId EventId {get;}

        public MessageFlair Flair {get;}

        public string ActorName {get;}
        
        [MethodImpl(Inline)]
        public WorkerFinished(string worker, CorrelationToken ct, MessageFlair flair = Finished)
        {
            EventId = evid(EventName, ct);
            ActorName = worker;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, EventId, ActorName);
    }
}