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
    public readonly struct Op128: IAsmOperand<Op128,W128,Fixed128>
    {
        public Fixed128 Content {get;}

        public SignKind Sign {get;}

        public AsmOperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public Op128(Fixed128 value, SignKind sign, AsmOperandKind kind)
        {
            Content = value;
            OpKind = kind;
            Sign = sign;
        }
    }
}