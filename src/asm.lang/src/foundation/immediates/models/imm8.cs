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
        public readonly struct imm8 : IImmOp8<Imm8>
        {
            public Imm8 Content {get;}

            [MethodImpl(Inline)]
            public imm8(byte value)
                => Content = value;

            public AsmOpKind OpKind
                => AsmOpKind.Imm | AsmOpKind.W8;

            [MethodImpl(Inline)]
            public static implicit operator Imm8(imm8 src)
                => src.Content;
        }
    }
}