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
    /// Defines a 512-bit operand
    /// </summary>
    public readonly struct Arg512: IAsmOperand<Arg512,W512,Cell512>
    {
        public byte Position {get;}

        public Cell512 Content {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg512(byte pos, Cell512 value, AsmOperandKind kind)
        {
            Position = pos;
            Content = value;
            Kind = kind;
        }
    }
}