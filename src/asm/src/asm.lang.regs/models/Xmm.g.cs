//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Xmm<R> : IRegister<Xmm<R>,W128,Cell128>, IAsmOperand<RegisterKind, Cell128>
        where R : unmanaged, IRegister
    {
        public Cell128 Content {get;}

        [MethodImpl(Inline)]
        public Xmm(Cell128 value)
            => Content = value;

        public RegisterKind Kind
            => default(R).Kind;

        [MethodImpl(Inline)]
        public static implicit operator Xmm(Xmm<R> src)
            => new Xmm(src.Content, src.Kind);
    }
}