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
    public readonly struct EmittingFileEvent : IWfEvent<EmittingFileEvent>
    {
        public const string EventName = GlobalEvents.EmittingFile;

        public const EventKind Kind = EventKind.EmittingFile;

        public WfEventId EventId {get;}

        public FS.FilePath Target {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public EmittingFileEvent(WfStepId step, FS.FilePath target, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, step);
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, Target.ToUri());
    }
}