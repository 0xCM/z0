//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct AsmAnalyzer
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<Link<Imm64,IceRegister>> moves(in AsmRoutine src, int capacity = 10)
        {
            var hander = new AsmMovHandler(capacity);
            var fx = span(src.Instructions.Data);
            var count = fx.Length;
            for(var i=0u; i<count; i++)
                hander.Handle(skip(fx, i));
            return hander.Collected;
        }
    }
}
