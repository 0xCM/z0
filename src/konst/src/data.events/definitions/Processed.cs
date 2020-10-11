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
    public readonly struct ProcessedEvent : IWfEvent<ProcessedEvent>
    {
        public const string EventName = GlobalEvents.Processed;

        public WfEventId EventId {get;}

        public FS.FileUri File {get;}

        public Count ProcessedCount {get;}

        public FlairKind Flair {get;}

        [MethodImpl (Inline)]
        public ProcessedEvent(WfStepId step, FS.FilePath file, Count count, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            File = file;
            ProcessedCount = count;
            Flair = flair;
        }

        [MethodImpl (Inline)]
        public string Format()
            => Render.format(EventId, File, ProcessedCount);
    }
}