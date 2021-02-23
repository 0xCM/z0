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
        public const EventKind Kind = EventKind.ProcessedFile;

        public const string EventName = GlobalEvents.ProcessedFile;

        public WfEventId EventId {get;}

        public FS.FilePath SourcePath {get;}

        public T Data {get;}

        public FlairKind Flair => FlairKind.Processed;

        [MethodImpl(Inline)]
        public ProcessedFileEvent(WfStepId step, FS.FilePath src, T data, CorrelationToken ct)
        {
            EventId = (Kind, step, ct);
            SourcePath = src;
            Data = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx3, EventId, Data, SourcePath.ToUri());
    }
}