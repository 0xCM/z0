//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Ymm<R> : IRegister<Ymm<R>,W256,Cell256>
        where R : unmanaged, IRegister
    {
        public Cell256 Content {get;}

        [MethodImpl(Inline)]
        public Ymm(Cell256 value)
        {
            Content = value;
        }

        public RegisterKind Kind
            => default;
    }
}