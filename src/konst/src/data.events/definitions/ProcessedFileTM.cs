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

    [Event(EventName)]
    public readonly struct ProcessedFileEvent<T,M> : IWfEvent<ProcessedFileEvent<T,M>>
    {
        public const string EventName = GlobalEvents.ProcessedFile;

        public WfEventId EventId {get;}

        public T FileKind {get;}

        public M Metric {get;}

        public FS.FilePath SourcePath {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ProcessedFileEvent(WfStepId step, FS.FilePath src, T kind,  M metric, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            SourcePath = src;
            FileKind = kind;
            Metric = metric;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx4, EventId, FileKind, Metric, SourcePath.ToUri());
    }
}