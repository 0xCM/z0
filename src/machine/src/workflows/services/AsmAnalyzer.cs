//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsmAnalyzer
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<Arrow<Imm64,Register>> moves(AsmFunction src, int capacity = 10)
        {
            var hander = new MovHandler(capacity);
            var inxs = span(src.Instructions.Data);
            for(var i=0u; i<inxs.Length; i++)
                hander.Handle(skip(inxs, i));            
            return hander.Collected;
        }
    }
}
