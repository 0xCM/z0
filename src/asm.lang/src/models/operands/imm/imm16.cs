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
        public readonly struct imm16 : IImmOp16<Imm16>
        {
            public Imm16 Content {get;}

            [MethodImpl(Inline)]
            public imm16(ushort value)
                => Content = value;

            public AsmOpClass OpClass
                => AsmOpClass.Imm;
        }
    }
}