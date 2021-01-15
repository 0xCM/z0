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
    /// Defines a 16-bit operand
    /// </summary>
    public readonly struct Arg16 : IAsmOperand<Arg16,W16,ushort>
    {
        public byte Position {get;}

        public ushort Content {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg16(byte pos, ushort value, SignKind sign, AsmOperandKind kind)
        {
            Position = pos;
            Content = value;
            Kind = kind;
        }
    }
}