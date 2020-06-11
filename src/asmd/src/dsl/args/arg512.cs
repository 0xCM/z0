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
    /// Defines a 512-bit oparand
    /// </summary>
    public readonly struct arg512: IOperand<arg512,W512,Fixed512>
    {
        public Fixed512 Value {get;}

        public Sign Sign {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public arg512(Fixed512 value, Sign sign, OperandKind kind)
        {
            Value = value;
            OpKind = kind;
            Sign = sign;
        }

        public DataWidth Width => DataWidth.W512;
    }
}