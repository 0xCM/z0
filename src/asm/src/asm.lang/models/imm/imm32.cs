//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmImm
    {
        public readonly struct imm32 : IImmOp<Imm32>
        {
            public Imm32 Content {get;}

            [MethodImpl(Inline)]
            public imm32(uint value)
                => Content = value;

            public AsmOpKind OpKind
                => AsmOpKind.Imm | AsmOpKind.W32;

            [MethodImpl(Inline)]
            public static implicit operator Arg32(imm32 src)
                => new Arg32(src.Content, src.OpKind);
        }
    }
}