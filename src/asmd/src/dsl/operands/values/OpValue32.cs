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
    /// Defines a 32-bit argument
    /// </summary>
    public readonly struct OpValue32 : IOperand<OpValue32,W32,Fixed32>
    {
        public Fixed32 Value {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public OpValue32(Fixed32 value, OperandKind kind)
        {
            Value = value;
            OpKind = kind;
        }

        public DataWidth Width => DataWidth.W32;
    }
}