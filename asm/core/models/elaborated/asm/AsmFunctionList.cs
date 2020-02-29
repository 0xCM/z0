//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public readonly struct AsmFunctionList : IAsmFunctionList
    {        
        public static AsmFunctionList Empty = IAsmFunctionList.Empty;
        
        [MethodImpl(Inline)]
        public static AsmFunctionList Define(params AsmFunction[] src)
            => new AsmFunctionList(src);

        [MethodImpl(Inline)]
        AsmFunctionList(AsmFunction[] src)
            => Items = src;
        
        public AnyList<AsmFunction> Items {get;}

        public Func<AsmFunction[], AsmFunctionList> Factory 
            => Define;
    }

    public interface IAsmFunctionList 
        : IAnyListProvider<AsmFunctionList, AsmFunction>{}

}