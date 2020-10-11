// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    [Event(EventName)]
    public readonly struct FileEmittedEvent : IWfEvent<FileEmittedEvent, FS.FilePath>, IWfFileEmission<FileEmittedEvent>
    {
        public const string EventName = "FileEmitted";

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public FS.FilePath Path {get;}

        public Count SegmentCount {get;}

        public FlairKind Flair {get;}


        [MethodImpl(Inline)]
        public FileEmittedEvent(WfStepId step, FS.FilePath path, Count segments, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            SegmentCount = segments;
            Path = path;
            Flair = flair;
        }

        public EventPayload<FS.FilePath> Payload
            => Path;

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, SegmentCount, Path.ToUri());
    }
}