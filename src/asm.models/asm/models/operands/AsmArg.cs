//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct AsmArg<T> : IOperand<T>
        where T : unmanaged
    {
        public T Content {get;}

        public SignKind Sign {get;}

        public uint Width {get;}

        public AsmOperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public AsmArg(T value, SignKind sign, AsmOperandKind kind, uint width)
        {
            Content = value;
            Sign = sign;
            Width =  width;
            OpKind = kind;
        }
    }
}