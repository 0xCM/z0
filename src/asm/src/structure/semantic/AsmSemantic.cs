//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly partial struct AsmQuery : IAsmQuery
    {
        public static IAsmQuery Service => default(AsmQuery);   
    }
    
    public interface IAsmSemantic : IFlowControl, IAsmQuery
    {
    }
    
    public readonly struct AsmSemantic : IAsmSemantic
    {
        public static IAsmSemantic Service => default(AsmSemantic);
    }
}