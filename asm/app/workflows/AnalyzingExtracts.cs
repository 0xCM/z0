//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = AnalyzingExtracts;

    public readonly struct AnalyzingExtracts : IAppEvent<E, MemberExtract[]>
    {        
        public static E Empty => Define(new MemberExtract[]{});
        
        [MethodImpl(Inline)]
        public static E Define(MemberExtract[] extracts)
            => new E(extracts);

        [MethodImpl(Inline)]
        AnalyzingExtracts(MemberExtract[] extracts)
        {
            Payload = extracts;
        }

        public string Description 
            => $"Analyzing extract report {Payload.Length} member extracts";

        public MemberExtract[] Payload{get;}

        public E Zero => Empty;        
    }
}