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
        public readonly struct imm16 : IAsmOperand<Imm16>
        {
            public Imm16 Content {get;}

            [MethodImpl(Inline)]
            public imm16(ushort value)
                => Content = value;

            public AsmOperandClass Kind
                => AsmOperandClass.Imm;

            [MethodImpl(Inline)]
            public static implicit operator Arg16(imm16 src)
                => new Arg16(src.Content, src.Kind);
        }
    }
}