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
    /// Defines the content of a 512-bit argument
    /// </summary>
    public readonly struct OpValue256: IOperand<OpValue256,W256,Fixed256>
    {
        public Fixed256 Value {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public OpValue256(Fixed256 value, OperandKind kind)
        {
            Value = value;
            OpKind = kind;
        }

        public DataWidth Width => DataWidth.W256;
    }
}