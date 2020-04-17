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
        public readonly struct AnalyzingExtracts : IAppEvent<AnalyzingExtracts, ApiMemberExtract[]>
        {        
            public static AnalyzingExtracts Empty => Define(new ApiMemberExtract[]{});
            
            [MethodImpl(Inline)]
            public static AnalyzingExtracts Define(ApiMemberExtract[] extracts)
                => new AnalyzingExtracts(extracts);

            [MethodImpl(Inline)]
            AnalyzingExtracts(ApiMemberExtract[] extracts)
            {
                Payload = extracts;
            }

            public string Description 
                => $"Analyzing extract report {Payload.Length} member extracts";

            public ApiMemberExtract[] Payload{get;}

            public AnalyzingExtracts Zero => Empty;        
        }
    }
}