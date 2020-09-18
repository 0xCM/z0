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
    using static z;

    partial struct WfEvents
    {
        [Event]
        public readonly struct ProcessedFile : IWfEvent<ProcessedFile>
        {
            public const string EventName = nameof(ProcessedFile);

            public WfEventId EventId {get;}

            public DataFlow<FS.FilePath> DataFlow {get;}

            public Count ProcessedSize {get;}

            public FlairKind Flair {get;}

            [MethodImpl (Inline)]
            public ProcessedFile(WfStepId step, DataFlow<FS.FilePath> flow, uint size, CorrelationToken ct, FlairKind flair = Ran)
            {
                EventId = (EventName, step, ct);
                DataFlow = flow;
                ProcessedSize = size;
                Flair = flair;
            }

            [MethodImpl (Inline)]
            public string Format()
                => Render.format(EventId, DataFlow, ProcessedSize);
        }
    }
}