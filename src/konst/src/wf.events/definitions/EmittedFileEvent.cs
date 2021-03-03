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
            EventId = WfEventId.define(EventName, step);
            SegmentCount = segments;
            Path = path;
        }

        [MethodImpl(Inline)]
        public EmittedFileEvent(WfStepId step, FS.FilePath path, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            SegmentCount = 0;
            Path = path;
        }

        public string Format()
            =>  SegmentCount != 0
            ? TextFormatter.format(EventId, SegmentCount, Msg.EmittedFile.Capture(Path.ToUri()))
            : TextFormatter.format(EventId, Msg.EmittedFile.Capture(Path.ToUri()));
    }
}