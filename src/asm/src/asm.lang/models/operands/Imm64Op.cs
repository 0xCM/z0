//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Imm64Op : IAsmOperand<Imm64>
    {
        public byte Position {get;}

        public Imm64 Content {get;}

        [MethodImpl(Inline)]
        public Imm64Op(byte pos, Imm64 value)
        {
            Position = pos;
            Content = value;
        }

        public AsmOperandKind Kind
            => AsmOperandKind.Imm;
    }
}