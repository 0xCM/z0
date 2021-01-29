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
        public readonly struct imm8 : IAsmOperand<Imm8>
        {
            public Imm8 Content {get;}

            [MethodImpl(Inline)]
            public imm8(byte value)
            {
                Content = value;
            }

            public AsmOperandClass Kind
                => AsmOperandClass.Imm;

            [MethodImpl(Inline)]
            public static implicit operator Arg8(imm8 src)
                => new Arg8(src.Content, src.Kind);
        }
    }
}