//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;
    using static FlairKinds;

    [Event]
    public readonly struct RanProcessor : IWfEvent<RanProcessor>
    {
        public const string EventName = nameof(RanProcessor);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfProcessor Processor {get;}

        public string Message {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public RanProcessor(string actor, string processor, string message, CorrelationToken ct,  FlairKind flair = Ran)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = actor;
            Processor = processor;
            Message =  message;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx4, EventId, Actor, Processor, Message);
    }
}