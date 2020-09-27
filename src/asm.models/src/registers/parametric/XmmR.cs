//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Xmm<R> : IXmmReg<Xmm<R>,R>
        where R : unmanaged, IRegister
    {
        public Cell128 Content {get;}

        [MethodImpl(Inline)]
        public Xmm(Cell128 value)
            => Content = value;

        public RegisterKind Kind
            => default(R).Kind;
    }
}