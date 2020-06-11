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
    /// Defines a 256-bit oparand
    /// </summary>
    public readonly struct arg256: IOperand<arg256,W256,Fixed256>
    {
        public Fixed256 Value {get;}

        public Sign Sign {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public arg256(Fixed256 value, Sign sign, OperandKind kind)
        {
            Value = value;
            OpKind = kind;
            Sign = sign;
        }

        public DataWidth Width => DataWidth.W256;
    }
}