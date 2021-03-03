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
        public EmittedFileEvent(WfStepId step, T payload, Count segments, FS.FilePath target, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            SegmentCount = segments;
            Payload = payload;
            Target = target;
        }

        [MethodImpl(Inline)]
        public EmittedFileEvent(WfStepId step, T payload, FS.FilePath target, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            SegmentCount = 0;
            Payload = payload;
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => SegmentCount != 0
            ? TextFormatter.format(EventId, Payload, SegmentCount, Msg.EmittedFile.Capture(Target.ToUri()))
            : TextFormatter.format(EventId, Payload, Msg.EmittedFile.Capture(Target.ToUri()));
    }
}