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
    /// Defines a 16-bit operand
    /// </summary>
    public readonly struct arg16 : IOperand<arg16,W16,ushort>
    {
        public ushort Content {get;}

        public SignKind Sign {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public arg16(ushort value, SignKind sign, OperandKind kind)
        {
            Content = value;
            OpKind = kind;
            Sign = sign;
        }

        public DataWidth Width 
            => DataWidth.W16;
    }
}