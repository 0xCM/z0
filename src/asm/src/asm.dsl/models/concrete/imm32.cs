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

            public AsmOperandKind Kind
                => AsmOperandKind.Imm;

            [MethodImpl(Inline)]
            public imm32(uint value)
            {
                Content = value;
            }
        }
    }
}