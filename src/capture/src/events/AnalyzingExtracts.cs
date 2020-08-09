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

    public readonly struct AnalyzingExtracts : IWfEvent<AnalyzingExtracts>
    {        
        public WfEventId EventId {get;}

        public string ActorName {get;}

        public ExtractedCode[] Extracts {get;}
        
        public uint ExtractCount 
            => (uint)Extracts.Length;

        [MethodImpl(Inline)]
        internal AnalyzingExtracts(string worker, ExtractedCode[] extracts, CorrelationToken ct)
        {
            EventId = evid(nameof(AnalyzingExtracts), ct);
            ActorName = worker;
            Extracts = extracts;
        }

        public string Format() 
            => text.format(PSx3, EventId, ActorName, ExtractCount);
    }
}