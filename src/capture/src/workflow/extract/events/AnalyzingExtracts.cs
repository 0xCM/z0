//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using E = ExtractionEvents.AnalyzingExtracts;

    partial class ExtractionEvents
    {
        public readonly struct AnalyzingExtracts : IAppEvent<E>
        {        
            public static E Empty => Define(new MemberExtract[]{});
            
            [MethodImpl(Inline)]
            public static E Define(MemberExtract[] extracts)
                => new E(extracts);

            [MethodImpl(Inline)]
            AnalyzingExtracts(MemberExtract[] extracts)
            {
                Extracts = extracts;
            }

            public string Description 
                => $"Analyzing extract report {Extracts.Length} member extracts";

            public MemberExtract[] Extracts {get;}

            public AnalyzingExtracts Zero => Empty;        
        }
    }
}