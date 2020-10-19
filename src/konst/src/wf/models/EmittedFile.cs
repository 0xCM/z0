// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    [Event(EventName)]
    public readonly struct EmittedFileEvent : IWfEvent<EmittedFileEvent>
    {
        public const string EventName = GlobalEvents.EmittedFile;

        public WfEventId EventId {get;}

        public FS.FilePath Path {get;}

        public Count SegmentCount {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public EmittedFileEvent(WfStepId step, FS.FilePath path, Count segments, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            SegmentCount = segments;
            Path = path;
            Flair = flair;
        }


        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, SegmentCount, Path.ToUri());
    }
}