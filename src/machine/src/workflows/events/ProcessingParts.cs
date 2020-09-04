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

    [Event]
    public readonly struct ProcessingParts : IWfEvent<ProcessingParts>
    {
        public const string EventName = nameof(ProcessingParts);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfProcessor Processor {get;}

        public PartId[] Parts {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ProcessingParts(string actor, string processor, PartId[] parts, CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = actor;
            Processor = processor;
            Parts = parts;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Actor, Processor, z.delimit(Parts));
    }
}