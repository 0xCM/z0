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
    /// Defines an 8-bit operand
    /// </summary>
    public readonly struct Arg8 : IAsmOperand<Arg8,W8,byte>
    {
        public byte Content {get;}

        public SignKind Sign {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg8(byte value, SignKind sign, AsmOperandKind kind)
        {
            Content = value;
            Kind = kind;
            Sign = sign;
        }
    }
}