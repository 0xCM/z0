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
        public static AsmEmissionGroup Define(AsmEmissionToken[] tokens)
            => new AsmEmissionGroup(tokens);
            
        [MethodImpl(Inline)]
        AsmEmissionGroup(AsmEmissionToken[] tokens)
        {
            this.Tokens = tokens;
        }

        public readonly AsmEmissionToken[] Tokens;                
    }
    
}