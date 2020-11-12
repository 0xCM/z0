//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct Zmm<R> : IRegister<Zmm<R>,W512,Cell512>
        where R : unmanaged, IRegister
    {
        public Cell512 Data;

        public Cell512 Content => Data;

        [MethodImpl(Inline)]
        public Zmm(Cell512 value)
            => Data = value;

        public RegisterKind Kind
            => default(R).Kind;
    }
}