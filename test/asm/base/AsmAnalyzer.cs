//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Dsl;

    using static Konst;
    using static Root;

    public readonly struct AsmAnalyzer
    {
        static ReadOnlySpan<ArrowPath<imm64,Register>> Analyze(ReadOnlySpan<AsmInstructionList> src)
        {
            var handler = new MovHandler(100);
            for(var i = 0; i<src.Length; i++)
            {
                var il = skip(src,i).Data.ToReadOnlySpan();
                
                for(var j=0; j<il.Length; j++)
                    handler.Handle(skip(il,j));
                                                
            }
            return handler.Collected;
        }

        public static ReadOnlySpan<ArrowPath<imm64,Register>> moves(AsmFunction src, int capacity = 10)
        {
            var hander = new MovHandler(capacity);
            var inxs = span(src.Inxs.Data);
            for(var i=0; i<inxs.Length; i++)
                hander.Handle(skip(inxs, i));            
            return hander.Collected;
        }
    }
}
