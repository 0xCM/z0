//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class ExtractionEvents
    {
        public readonly struct AnalyzingExtracts : IAppEvent<AnalyzingExtracts, ExtractedMember[]>
        {        
            public static AnalyzingExtracts Empty => Define(new ExtractedMember[]{});
            
            [MethodImpl(Inline)]
            public static AnalyzingExtracts Define(ExtractedMember[] extracts)
                => new AnalyzingExtracts(extracts);

            [MethodImpl(Inline)]
            AnalyzingExtracts(ExtractedMember[] extracts)
            {
                Payload = extracts;
            }

            public string Description 
                => $"Analyzing extract report {Payload.Length} member extracts";

            public ExtractedMember[] Payload{get;}

            public AnalyzingExtracts Zero => Empty;        
        }
    }
}