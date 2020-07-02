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
        public T Content {get;}

        public SignKind Sign {get;}

        public uint Width {get;}

        public AsmOperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public arg(T value, SignKind sign, AsmOperandKind kind, uint width)
        {
            Content = value;
            Sign = sign;
            Width =  width;
            OpKind = kind;
        }
    }
}