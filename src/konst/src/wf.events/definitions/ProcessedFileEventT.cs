//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public readonly struct ProcessedFileEvent<T> : IWfEvent<ProcessedFileEvent<T>>
    {
        public const string EventName = GlobalEvents.ProcessedFile;

        public const EventKind Kind = EventKind.ProcessedFile;

        public WfEventId EventId {get;}

        public FS.FilePath SourcePath {get;}

        public T FileKind {get;}

        public FlairKind Flair => FlairKind.Processed;

        [MethodImpl(Inline)]
        public ProcessedFileEvent(WfStepId step, FS.FilePath src, T kind, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            SourcePath = src;
            FileKind = kind;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx3, EventId, FileKind, SourcePath.ToUri());
    }
}