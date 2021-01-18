//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Imm8Op : IAsmOperand<Imm8>
    {
        public byte Position {get;}

        public Imm8 Content {get;}

        [MethodImpl(Inline)]
        public Imm8Op(byte pos, Imm8 value)
        {
            Position = pos;
            Content = value;
        }

        public AsmOperandKind Kind
            => AsmOperandKind.Imm;

        [MethodImpl(Inline)]
        public static implicit operator Arg8(Imm8Op src)
            => new Arg8(src.Position, src.Content, src.Kind);
    }
}