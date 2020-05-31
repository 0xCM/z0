//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct OperandValue<T> : IOperandValue<T>
        where T : unmanaged
    {
        public DataWidth Width {get;}

        public OperandKind Kind {get;}

        public T Data {get;}

        [MethodImpl(Inline)]
        public OperandValue(OperandKind kind, DataWidth width, T data)
        {
            Width =  width;
            Kind = kind;
            Data = data;

        }
    }
    
    public readonly struct Operand : IOperandSpec
    {
        public DataWidth Width {get;}

        public OperandKind Kind {get;}
    }
}