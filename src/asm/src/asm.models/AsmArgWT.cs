//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Arg<W,T> : IAsmOperand<Arg<W,T>,W,T>
        where T : unmanaged
        where W : unmanaged, IDataWidth
    {
        public T Content {get;}

        public SignKind Sign {get;}

        public uint Width {get;}

        public AsmOperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Arg(T value, SignKind sign, AsmOperandKind kind, uint width)
        {
            Content = value;
            Sign = sign;
            Width =  width;
            Kind = kind;
        }
    }
}