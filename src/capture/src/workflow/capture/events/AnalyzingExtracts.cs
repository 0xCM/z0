//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using E = AnalyzingExtracts;

    public readonly struct AnalyzingExtracts : IAppEvent<E>
    {        
        public ExtractedCode[] Extracts {get;}
        
        [MethodImpl(Inline)]
        internal AnalyzingExtracts(ExtractedCode[] extracts)
        {
            Extracts = extracts;
        }

        public string Description 
            => $"Analyzing extract report {Extracts.Length} member extracts";

        public AnalyzingExtracts Zero 
            => Empty;        

        public static E Empty 
            => new E(Array.Empty<ExtractedCode>());
    }
}