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
        public byte Position {get;}

        public T Content {get;}

        public AsmOperandKind Kind {get;}

        public uint Width {get;}

        [MethodImpl(Inline)]
        public Arg(byte pos, T value, AsmOperandKind kind, uint width)
        {
            Position = pos;
            Content = value;
            Width =  width;
            Kind = kind;
        }
    }
}