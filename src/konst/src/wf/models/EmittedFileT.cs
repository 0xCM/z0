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

    [Event(EventName)]
    public readonly struct EmittedFileEvent<T> : IWfEvent<EmittedFileEvent<T>>
    {
        public const string EventName = GlobalEvents.EmittedFile;

        public WfEventId EventId {get;}

        public InputValue<T> Source {get;}

        public FS.FilePath Target {get;}

        public Count SegmentCount {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public EmittedFileEvent(WfStepId step, T source, Count segments, FS.FilePath target, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            SegmentCount = segments;
            Source = source;
            Target = target;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Source, SegmentCount, Target.ToUri());
    }
}