//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Xmm<R> : IRegister<Xmm<R>,W128,Cell128>, IRegOp128<Cell128>
        where R : unmanaged, IRegister
    {
        public Cell128 Content {get;}

        [MethodImpl(Inline)]
        public Xmm(Cell128 value)
            => Content = value;

        public RegisterKind RegKind
            => default(R).RegKind;

        [MethodImpl(Inline)]
        public static implicit operator Xmm(Xmm<R> src)
            => new Xmm(src.Content, src.RegKind);
    }
}