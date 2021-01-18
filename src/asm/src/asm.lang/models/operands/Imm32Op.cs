//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Imm32Op : IAsmOperand<Imm32>
    {
        public byte Position {get;}

        public Imm32 Content {get;}

        public AsmOperandKind Kind
            => AsmOperandKind.Imm;

        [MethodImpl(Inline)]
        public Imm32Op(byte pos, Imm32 value)
        {
            Position = pos;
            Content = value;
        }
    }
}