//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a 16-bit operand
    /// </summary>
    public readonly struct Arg16 : IAsmOperand<Arg16,W16,ushort>
    {
        public ushort Content {get;}

        public SignKind Sign {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg16(ushort value, SignKind sign, AsmOperandKind kind)
        {
            Content = value;
            Kind = kind;
            Sign = sign;
        }
    }
}