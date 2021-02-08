//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Ymm<R> : IRegister<Ymm<R>,W256,Cell256>, IRegOp<Cell256>
        where R : unmanaged, IRegister
    {
        public Cell256 Content {get;}

        [MethodImpl(Inline)]
        public Ymm(Cell256 value)
            => Content = value;

        public RegisterKind RegKind
            => default;

        [MethodImpl(Inline)]
        public static implicit operator Ymm(Ymm<R> src)
            => new Ymm(src.Content, src.RegKind);
    }
}