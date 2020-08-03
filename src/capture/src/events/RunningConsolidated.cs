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
        const string Pattern = "{0}: Running consolidated capture workflow over {1} catalogs";

        public WfEventId Id {get;}

        public readonly int Count;

        [MethodImpl(Inline)]
        public RunningConsolidated(int count, CorrelationToken? ct = null)
        {
            Count = count;
            Id = WfEventId.define(nameof(RunningConsolidated), ct);
        }

        public string Format() 
            => text.format(Pattern, Id,Count);
    }    
}