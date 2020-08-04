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
        const string Pattern = IdMarker + "{1} | Running consolidated capture workflow over {2} catalogs";

        public WfEventId Id {get;}

        public string WorkerName {get;}
        
        public readonly int Count;

        [MethodImpl(Inline)]
        public RunningConsolidated(string worker, int count, CorrelationToken? ct = null)
        {
            WorkerName = worker;
            Count = count;
            Id = WfEventId.define(nameof(RunningConsolidated), ct);
        }

        public string Format() 
            => text.format(Pattern, Id, WorkerName, Count);
    }    
}