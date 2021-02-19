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
    public readonly struct ProcessedFileEvent : IWfEvent<ProcessedFileEvent>
    {
        public const EventKind Kind = EventKind.ProcessedFile;

        public WfEventId EventId {get;}

        public FS.FilePath SourcePath {get;}

        public FlairKind Flair => FlairKind.Processed;

        [MethodImpl(Inline)]
        public ProcessedFileEvent(WfStepId step, FS.FilePath src, CorrelationToken ct)
        {
            EventId = (Kind, step, ct);
            SourcePath = src;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx2, EventId, SourcePath.ToUri());
    }
}