//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct RunningConsolidated : IWfEvent<RunningConsolidated>
    {            
        public const string EventName = nameof(RunningConsolidated);

        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public readonly uint CatalogCount;

        [MethodImpl(Inline)]
        public RunningConsolidated(string actor, uint count, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, ct);
            ActorName = actor;
            CatalogCount = count;
        }
        
        public object Description 
            => new {CatalogCount};
        
        public string Format() 
            => text.format(PSx3, EventId, ActorName, Description);
    }    
}