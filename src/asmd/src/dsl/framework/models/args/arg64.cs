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
    /// Defines a 64-bit oparand
    /// </summary>
    public readonly struct arg64 : IOperand<arg64,W64,ulong>
    {
        public ulong Content {get;}

        public SignKind Sign {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public arg64(ulong value, SignKind sign, OperandKind kind)
        {
            Content = value;
            OpKind = kind;
            Sign = sign;
        }

        public DataWidth Width 
            => DataWidth.W64;
    }
}