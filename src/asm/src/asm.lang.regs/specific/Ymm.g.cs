//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Ymm<R> : IRegister<Ymm<R>,W256,Cell256>, IAsmOperand<RegisterKind, Cell256>
        where R : unmanaged, IRegister
    {
        public byte Position {get;}

        public Cell256 Content {get;}

        [MethodImpl(Inline)]
        public Ymm(byte pos, Cell256 value)
        {
            Position = pos;
            Content = value;
        }

        public RegisterKind Kind
            => default;
    }
}