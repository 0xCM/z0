//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Operand<T> : IOperand<T>
        where T : unmanaged
    {
        public DataWidth Width {get;}

        public OperandKind Kind {get;}

        public T Data {get;}

        [MethodImpl(Inline)]
        public Operand(OperandKind kind, DataWidth width, T data)
        {
            Width =  width;
            Kind = kind;
            Data = data;

        }
 
    }
    
    public readonly struct Operand : IOperand
    {
        public DataWidth Width {get;}

        public OperandKind Kind {get;}

    }

}