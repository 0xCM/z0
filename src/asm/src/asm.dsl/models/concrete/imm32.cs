//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDsl
    {
        public readonly struct imm32 : IAsmOperand<Imm32>
        {
            public Imm32 Content {get;}

            [MethodImpl(Inline)]
            public imm32(uint value)
                => Content = value;

            public AsmOperandClass Kind
                => AsmOperandClass.Imm;

            [MethodImpl(Inline)]
            public static implicit operator Arg32(imm32 src)
                => new Arg32(src.Content, src.Kind);
        }
    }
}