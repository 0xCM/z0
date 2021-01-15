//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a 256-bit operand
    /// </summary>
    public readonly struct Arg256: IAsmOperand<Arg256,W256,Cell256>
    {
        public byte Position {get;}

        public Cell256 Content {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg256(byte pos, Cell256 value, SignKind sign, AsmOperandKind kind)
        {
            Position = pos;
            Content = value;
            Kind = kind;
        }
    }
}