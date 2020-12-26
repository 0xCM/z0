// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Event(Kind)]
    public readonly struct EmittedFileEvent : IWfEvent<EmittedFileEvent>
    {
        public const string EventName = GlobalEvents.EmittedFile;

        public const EventKind Kind = EventKind.EmittedFile;

        public WfEventId EventId {get;}

        public FS.FilePath Path {get;}

        public Count SegmentCount {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public EmittedFileEvent(WfStepId step, FS.FilePath path, Count segments, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            SegmentCount = segments;
            Path = path;
        }
        public string Format()
            => TextFormatter.format(EventId, SegmentCount, Path.ToUri());
    }
}