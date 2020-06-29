//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IAsmSemantic : TSemanticQuery
    {

            
    }
    
    [ApiHost("semantic")]
    public readonly struct AsmSemantic : IAsmSemantic, IApiHost<AsmSemantic>
    {
        public static IAsmSemantic Service => default(AsmSemantic);
    }
}