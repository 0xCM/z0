//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct OpValue<T> : IOperand<T>
        where T : unmanaged
    {
        public T Value {get;}

        public DataWidth Width {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public OpValue(T value, OperandKind kind, DataWidth width)
        {
            Value = value;
            Width =  width;
            OpKind = kind;
        }
    }
}