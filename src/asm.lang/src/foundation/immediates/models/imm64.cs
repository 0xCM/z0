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
        public readonly struct imm64 : IImmOp64<Imm64>
        {
            public Imm64 Content {get;}

            [MethodImpl(Inline)]
            public imm64(ulong value)
                => Content = value;

            public AsmOpKind OpKind
                => AsmOpKind.Imm | AsmOpKind.W64;
        }
    }
}