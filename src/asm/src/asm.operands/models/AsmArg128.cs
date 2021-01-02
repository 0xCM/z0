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
    /// Defines a 128-bit operand
    /// </summary>
    public readonly struct Arg128: IAsmOperand<Arg128,W128,Cell128>
    {
        public Cell128 Content {get;}

        public SignKind Sign {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg128(Cell128 value, SignKind sign, AsmOperandKind kind)
        {
            Content = value;
            Kind = kind;
            Sign = sign;
        }
    }
}