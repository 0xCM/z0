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
    public readonly struct ProcessedEvent<S,T> : IWfEvent<ProcessedEvent<S,T>>
    {

        public const EventKind Kind = EventKind.Processed;

        public WfEventId EventId {get;}

        public DataFlow<S,T> DataFlow {get;}

        public FlairKind Flair => FlairKind.Processed;

        [MethodImpl (Inline)]
        public ProcessedEvent(WfStepId step, DataFlow<S,T> flow, CorrelationToken ct)
        {
            EventId = (Kind, step, ct);
            DataFlow = flow;
        }

        [MethodImpl (Inline)]
        public string Format()
            => TextFormatter.format(EventId, DataFlow);
    }
}