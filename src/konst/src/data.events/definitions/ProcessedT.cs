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
    public readonly struct ProcessedEvent<T> : IWfEvent<ProcessedEvent<T>>
    {
        public const string EventName = GlobalEvents.Processed;

        public WfEventId EventId {get;}

        public OutputValue<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl (Inline)]
        public ProcessedEvent(WfStepId step, T content, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            Content = content;
            Flair = flair;
        }

        [MethodImpl (Inline)]
        public string Format()
            => Render.format(EventId, Content);
    }
}