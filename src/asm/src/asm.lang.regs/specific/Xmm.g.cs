//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Xmm<R> : IRegister<Xmm<R>,W128,Cell128>
        where R : unmanaged, IRegister
    {
        public Cell128 Data;

        public Cell128 Content => Data;

        [MethodImpl(Inline)]
        public Xmm(Cell128 value)
            => Data = value;

        public RegisterKind Kind
            => default(R).Kind;
    }
}