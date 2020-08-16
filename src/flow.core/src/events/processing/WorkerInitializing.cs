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
    using static Render;
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WorkerInitializing : IWfEvent<WorkerInitializing>
    {        
        public const string EventName = nameof(WorkerInitializing);

        public WfEventId EventId {get;}
        
        public string ActorName {get;}
        
        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WorkerInitializing(string worker, CorrelationToken ct, MessageFlair flair = Initializing)
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