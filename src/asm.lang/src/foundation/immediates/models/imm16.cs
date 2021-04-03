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
        public readonly struct imm16 : IImmOp16<Imm16>
        {
            public Imm16 Content {get;}

            [MethodImpl(Inline)]
            public imm16(ushort value)
                => Content = value;

            public AsmOpKind OpKind
                => AsmOpKind.Imm;
        }
    }
}