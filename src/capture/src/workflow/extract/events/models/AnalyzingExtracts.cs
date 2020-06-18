//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using E = ExtractionEvents.AnalyzingExtracts;

    partial class ExtractionEvents
    {
        public readonly struct AnalyzingExtracts : IAppEvent<E>
        {        
            public static E Empty => Define(new ExtractedMember[]{});
            
            [MethodImpl(Inline)]
            public static E Define(ExtractedMember[] extracts)
                => new E(extracts);

            [MethodImpl(Inline)]
            AnalyzingExtracts(ExtractedMember[] extracts)
            {
                Extracts = extracts;
            }

            public string Description 
                => $"Analyzing extract report {Extracts.Length} member extracts";

            public ExtractedMember[] Extracts {get;}

            public AnalyzingExtracts Zero => Empty;        
        }
    }
}