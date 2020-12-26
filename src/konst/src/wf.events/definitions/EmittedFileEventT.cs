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
    public readonly struct EmittedFileEvent<T> : IWfEvent<EmittedFileEvent<T>,T>
    {
        public const string EventName = GlobalEvents.EmittedFile;

        public const EventKind Kind = EventKind.EmittedFile;

        public WfEventId EventId {get;}

        public EventPayload<T> Payload {get;}

        public FS.FilePath Target {get;}

        public Count SegmentCount {get;}

        public FlairKind Flair => FlairKind.Ran;

        [MethodImpl(Inline)]
        public EmittedFileEvent(WfStepId step, T source, Count segments, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            SegmentCount = segments;
            Payload = source;
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, Payload, SegmentCount, Target.ToUri());
    }
}