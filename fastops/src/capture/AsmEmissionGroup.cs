//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct AsmEmissionGroup
    {
        [MethodImpl(Inline)]
        public static AsmEmissionGroup Define(OpIdentity groupid, AsmEmissionToken[] tokens)
            => new AsmEmissionGroup(groupid, tokens);
            
        [MethodImpl(Inline)]
        AsmEmissionGroup(OpIdentity groupid, AsmEmissionToken[] tokens)
        {
            this.Tokens = tokens;
            this.Id = groupid;
        }

        public readonly OpIdentity Id;
        
        public readonly AsmEmissionToken[] Tokens;                
    }
    
}