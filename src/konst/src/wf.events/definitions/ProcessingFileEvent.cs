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
    public readonly struct ProcessingFileEvent : IWfEvent<ProcessingFileEvent>
    {
        public const string EventName = GlobalEvents.ProcessingFile;

        public const EventKind Kind = EventKind.ProcessingFile;

        public WfEventId EventId {get;}

        public FS.FilePath SourcePath {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public ProcessingFileEvent(WfStepId step, FS.FilePath src, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            SourcePath = src;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, SourcePath.ToUri());
    }
}