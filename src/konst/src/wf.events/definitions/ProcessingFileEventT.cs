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

    [Event(EventName)]
    public readonly struct ProcessingFileEvent<T> : IWfEvent<ProcessingFileEvent<T>>
    {
        public const string EventName = GlobalEvents.ProcessingFile;

        public WfEventId EventId {get;}

        public T FileKind {get;}

        public FS.FilePath SourcePath {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ProcessingFileEvent(WfStepId step, T kind, FS.FilePath src, CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = (EventName, step, ct);
            SourcePath = src;
            FileKind = kind;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, SourcePath.ToUri());
    }
}