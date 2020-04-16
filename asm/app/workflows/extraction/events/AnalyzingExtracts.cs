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
        public readonly struct AnalyzingExtracts : IAppEvent<AnalyzingExtracts, MemberExtract[]>
        {        
            public static AnalyzingExtracts Empty => Define(new MemberExtract[]{});
            
            [MethodImpl(Inline)]
            public static AnalyzingExtracts Define(MemberExtract[] extracts)
                => new AnalyzingExtracts(extracts);

            [MethodImpl(Inline)]
            AnalyzingExtracts(MemberExtract[] extracts)
            {
                Payload = extracts;
            }

            public string Description 
                => $"Analyzing extract report {Payload.Length} member extracts";

            public MemberExtract[] Payload{get;}

            public AnalyzingExtracts Zero => Empty;        
        }
    }
}