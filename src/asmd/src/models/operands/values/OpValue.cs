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
        public DataWidth Width {get;}

        public OperandKind OpKind {get;}

        public T Data {get;}

        [MethodImpl(Inline)]
        public OpValue(OperandKind kind, DataWidth width, T data)
        {
            Width =  width;
            OpKind = kind;
            Data = data;
        }
    }
}