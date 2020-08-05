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

    public readonly struct RunningProcessor : IWfEvent<RunningProcessor>
    {
        public const string EventName = nameof(RunningProcessor);

        public WfEventId Id {get;}

        public string ActorName {get;}
    
        public string ProcessorName {get;}
        
        public AppMsgColor Flair {get;}
        
    
        [MethodImpl(Inline)]
        public RunningProcessor(string actor, string processor, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Magenta)
        {
            Id = WfEventId.define(EventName, ct);
            ActorName = actor;
            ProcessorName = processor;            
            Flair = flair;
        }

        
        [MethodImpl(Inline)]        
        public string Format()
             => text.format(PSx3, Id, ActorName, ProcessorName);               
    }        
}