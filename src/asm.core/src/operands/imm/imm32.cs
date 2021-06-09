//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOps
    {
        public readonly struct imm32 : IImmOp32<Imm32>
        {
            public Imm32 Content {get;}

            [MethodImpl(Inline)]
            public imm32(uint value)
                => Content = value;

            public AsmOpClass OpClass
                => AsmOpClass.Imm;

            public string Format()
                => Content.Format();

            public override string ToString()
                => Format();

        }
    }
}