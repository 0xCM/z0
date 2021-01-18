//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Imm16Op : IAsmOperand<Imm16>
    {
        public byte Position {get;}

        public Imm16 Content {get;}

        [MethodImpl(Inline)]
        public Imm16Op(byte pos, Imm16 value)
        {
            Position = pos;
            Content = value;
        }

        public AsmOperandKind Kind
            => AsmOperandKind.Imm;

        [MethodImpl(Inline)]
        public static implicit operator Arg16(Imm16Op src)
            => new Arg16(src.Position, src.Content, src.Kind);
    }
}