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
    /// Defines a 64-bit operand
    /// </summary>
    public readonly struct Arg64 : IAsmOperand<Arg64,W64,ulong>
    {
        public byte Position {get;}

        public ulong Content {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg64(byte pos, ulong value, AsmOperandKind kind)
        {
            Position = pos;
            Content = value;
            Kind = kind;
        }
    }
}