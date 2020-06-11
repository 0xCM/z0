//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;


    public readonly struct arg<T> : IOperand<T>
        where T : unmanaged
    {
        public T Value {get;}

        public Sign Sign {get;}

        public DataWidth Width {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public arg(T value, Sign sign, OperandKind kind, DataWidth width)
        {
            Value = value;
            Sign = sign;
            Width =  width;
            OpKind = kind;
        }
    }
}