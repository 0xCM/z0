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
        public readonly struct imm64 : IAsmOperand<Imm64>
        {
            public Imm64 Content {get;}

            [MethodImpl(Inline)]
            public imm64(ulong value)
                => Content = value;

            public AsmOperandClass Kind
                => AsmOperandClass.Imm;

            [MethodImpl(Inline)]
            public static implicit operator Arg64(imm64 src)
                => new Arg64(src.Content, src.Kind);
        }
    }
}