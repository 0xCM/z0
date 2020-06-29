//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    [ApiHost("query")]
    public readonly partial struct AsmQuery : TSemanticQuery
    {
        public static AsmQuery Direct => default(AsmQuery);
        
        public static TSemanticQuery Service => default(AsmQuery);   
    }  
}