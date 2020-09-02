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
    public readonly struct WorkerCreated : IWfEvent<WorkerCreated>
    {
        public const string EventName = nameof(WorkerCreated);

        public WfEventId EventId {get;}

        public WfWorker Worker {get;}

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public WorkerCreated(in WfWorker worker, CorrelationToken ct, MessageFlair flair = Created)
        {
            EventId = z.evid(EventName, ct);
            Worker = worker;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx2, EventId, Worker);
    }
}