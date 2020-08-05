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

    public readonly struct ProcessingParts : IWfEvent<ProcessingParts>
    {
        public const string EventName = nameof(ProcessingParts);
        
        public WfEventId Id {get;}

        public string ActorName {get;}

        public string ProcessorName {get;}

        public PartId[] Parts {get;}
        
        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public ProcessingParts(string actor, string processor, PartId[] parts, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Magenta)
        {
            Id = WfEventId.define(EventName, ct);
            ActorName = actor;
            ProcessorName = processor;
            Parts = parts;
            Flair = flair;
        }
        
        [MethodImpl(Inline)]        
        public string Format()
            => text.format(PSx4, Id, ActorName, ProcessorName, Parts.Format());               
    }        
}