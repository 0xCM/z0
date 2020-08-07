//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    [Event]
    public readonly struct RanProcessor : IWfEvent<RanProcessor>
    {
        public const string EventName = nameof(RanProcessor);
        
        public WfEventId EventId {get;}

        public string ActorName {get;}

        public string ProcessorName {get;}

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public RanProcessor(string actor, string processor, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Magenta)
        {
            EventId = WfEventId.define(EventName, ct);
            ActorName = actor;
            ProcessorName = processor;
            Flair = flair;
        }
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(PSx3, EventId, ActorName, ProcessorName);               
    }        
}