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
        const string Pattern = PSx3;

        public WfEventId Id {get;}

        public string WorkerName {get;}

        public ExtractedCode[] Extracts {get;}
        
        public uint ExtractCount 
            => (uint)Extracts.Length;

        [MethodImpl(Inline)]
        internal AnalyzingExtracts(string worker, ExtractedCode[] extracts, CorrelationToken ct)
        {
            Id = wfid(nameof(AnalyzingExtracts), ct);
            WorkerName = worker;
            Extracts = extracts;
        }

        public string Format() 
            => text.format(Pattern, Id, WorkerName, ExtractCount);
    }
}