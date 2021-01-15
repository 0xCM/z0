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
    /// Defines a 32-bit operand
    /// </summary>
    public readonly struct Arg32 : IAsmOperand<Arg32,W32,uint>
    {
        public byte Position {get;}

        public uint Content {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg32(byte pos, uint value, SignKind sign, AsmOperandKind kind)
        {
            Position = pos;
            Content = value;
            Kind = kind;
        }
    }
}