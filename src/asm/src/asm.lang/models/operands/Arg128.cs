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
    /// Defines a 128-bit operand
    /// </summary>
    public readonly struct Arg128: IAsmOperand<Arg128,W128,Cell128>
    {
        public byte Position {get;}

        public Cell128 Content {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg128(byte pos, Cell128 value, AsmOperandKind kind)
        {
            Content = value;
            Kind = kind;
            Position = pos;
        }
    }
}