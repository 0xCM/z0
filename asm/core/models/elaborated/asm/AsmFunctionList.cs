//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
    using static Root;

    public readonly struct AsmFunctionList : IAnyFiniteSeq<AsmFunctionList, AsmFunction>
    {        
        public static AsmFunctionList Empty = new AsmFunctionList(new AsmFunction[]{});
        
        [MethodImpl(Inline)]
        public static AsmFunctionList Define(params AsmFunction[] src)
            => new AsmFunctionList(src);

        [MethodImpl(Inline)]
        AsmFunctionList(AsmFunction[] src)
            => Content = src;
        
        public AsmFunction[] Content {get;}

        public AnyFiniteSeqFactory<AsmFunction, AsmFunctionList> Factory
            => Define;        
    }
}