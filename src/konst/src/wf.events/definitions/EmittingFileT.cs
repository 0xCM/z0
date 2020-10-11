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
    public readonly struct EmittingFileEvent<T> : IWfEvent<EmittingFileEvent<T>>
    {
        public const string EventName = "EmittingFile";

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public InputValue<T> Source {get;}

        public FS.FilePath Target {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public EmittingFileEvent(WfStepId step, T source, FS.FilePath target, CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = (EventName, step, ct);
            StepId = step;
            Source = source;
            Target = target;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Source, Target.ToUri());
    }
}