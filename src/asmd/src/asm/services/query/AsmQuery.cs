//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("query")]
    public readonly partial struct AsmQuery : ISemanticQuery, IApiHost<AsmQuery>
    {
        public static AsmQuery Direct => default(AsmQuery);
        
        public static ISemanticQuery Service => default(AsmQuery);   
    }
   
}