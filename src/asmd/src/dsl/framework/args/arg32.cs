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
    /// Defines a 32-bit oparand
    /// </summary>
    public readonly struct arg32 : IOperand<arg32,W32,Fixed32>
    {
        public Fixed32 Value {get;}

        public SignKind Sign {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public arg32(Fixed32 value, SignKind sign, OperandKind kind)
        {
            Value = value;
            OpKind = kind;
            Sign = sign;
        }

        public DataWidth Width => DataWidth.W32;
    }
}