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
    using static Flairs;

    [Event]
    public readonly struct RunningProcessor : IWfEvent<RunningProcessor>
    {
        public const string EventName = nameof(RunningProcessor);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}
    
        public WfProcessor Processor {get;}
        
        public AppMsgColor Flair {get;}        
    
        [MethodImpl(Inline)]
        public RunningProcessor(string actor, string processor, CorrelationToken ct, AppMsgColor flair = Running)
        {
            EventId = WfEventId.define(EventName, ct);
            Actor = actor;
            Processor = processor;            
            Flair = flair;
        }

        
        [MethodImpl(Inline)]        
        public string Format()
             => format(EventId, Actor, Processor);               
    }        
}