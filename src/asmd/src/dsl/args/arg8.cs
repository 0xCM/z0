//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an 8-bit operand
    /// </summary>
    public readonly struct arg8 : IOperand<arg8,W8,Fixed8>
    {
        public Fixed8 Value {get;}

        public SignKind Sign {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public arg8(Fixed8 value, SignKind sign, OperandKind kind)
        {
            Value = value;
            OpKind = kind;
            Sign = sign;
        }

        public DataWidth Width => DataWidth.W8;
    }
}