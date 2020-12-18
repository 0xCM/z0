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
    public readonly struct ProcessingFileEvent<T> : IWfEvent<ProcessingFileEvent<T>>
    {
        public const string EventName = GlobalEvents.ProcessingFile;

        public WfEventId EventId {get;}

        public T FileKind {get;}

        public FS.FilePath SourcePath {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public ProcessingFileEvent(WfStepId step, T kind, FS.FilePath src, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            SourcePath = src;
            FileKind = kind;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, SourcePath.ToUri());
    }
}