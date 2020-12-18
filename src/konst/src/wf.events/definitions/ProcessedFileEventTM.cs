//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(EventName)]
    public readonly struct ProcessedFileEvent<T,M> : IWfEvent<ProcessedFileEvent<T,M>>
    {
        public const string EventName = GlobalEvents.ProcessedFile;

        public WfEventId EventId {get;}

        public T FileKind {get;}

        public M Metric {get;}

        public FS.FilePath SourcePath {get;}

        public FlairKind Flair => FlairKind.Processed;

        [MethodImpl(Inline)]
        public ProcessedFileEvent(WfStepId step, FS.FilePath src, T kind,  M metric, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            SourcePath = src;
            FileKind = kind;
            Metric = metric;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx4, EventId, FileKind, Metric, SourcePath.ToUri());
    }
}