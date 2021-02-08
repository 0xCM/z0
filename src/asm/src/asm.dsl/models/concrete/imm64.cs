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
        public readonly struct imm64 : IImmOp<Imm64>
        {
            public Imm64 Content {get;}

            [MethodImpl(Inline)]
            public imm64(ulong value)
                => Content = value;

            public AsmOpKind OpKind
                => AsmOpKind.Imm | AsmOpKind.W64;

            [MethodImpl(Inline)]
            public static implicit operator Arg64(imm64 src)
                => new Arg64(src.Content, src.OpKind);
        }
    }
}