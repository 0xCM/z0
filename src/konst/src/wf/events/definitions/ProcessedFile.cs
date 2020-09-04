//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.IO;
    using System.Runtime.CompilerServices;
    using System;

    using static Konst;
    using static Render;
    using static RenderPatterns;
    using static z;

    partial struct WfEvents
    {
        [Event]
        public readonly struct ProcessedFile<T> : IWfEvent<ProcessedFile<T>>
        {
            public const string EventName = nameof(ProcessedFile<T>);

            public WfEventId EventId {get;}

            public string ActorName {get;}

            public T FileKind {get;}

            public FS.FilePath Source {get;}

            public FS.FilePath Target {get;}

            public uint ProcessedSize {get;}

            public FlairKind Flair {get;}

            [MethodImpl (Inline)]
            public ProcessedFile(string worker, T kind, FilePath src, uint size, CorrelationToken ct, FlairKind flair = Ran)
            {
                EventId = evid (EventName, ct);
                ActorName = worker;
                Source = FS.path (src.Name);
                Target = FS.FilePath.Empty;
                FileKind = kind;
                ProcessedSize = size;
                Flair = flair;
            }

            [MethodImpl (Inline)]
            public ProcessedFile(WfStepId step, T content, WfDataFlow<FS.FilePath> flow, uint size, CorrelationToken ct, FlairKind flair = Ran)
            {
                EventId = (EventName, step, ct);
                ActorName = step.Name;
                Source = flow.Source;
                Target = flow.Target;
                FileKind = content;
                ProcessedSize = size;
                Flair = flair;
            }

            [MethodImpl (Inline)]
            public string Format()
                => text.format(PSx4, EventId, ActorName, ProcessedSize, Source);
        }
    }
}