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
    using static Control;

    public readonly struct AsmAnalyzer
    {
        public static ReadOnlySpan<ArrowPath<imm64,Register>> Analyze(ReadOnlySpan<AsmInstructionList> src)
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
    }
}
