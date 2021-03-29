//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Arg<W,T> : IAsmOp<Arg<W,T>,W,T>
        where T : unmanaged
        where W : unmanaged, IDataWidth
    {
        public byte Position {get;}

        public T Content {get;}

        public AsmOpKind OpKind {get;}

        [MethodImpl(Inline)]
        public Arg(byte pos, T value, AsmOpKind kind)
        {
            Position = pos;
            Content = value;
            OpKind = kind;
        }
    }
}