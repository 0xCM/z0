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
        public byte Position {get;}

        public Cell128 Content {get;}

        [MethodImpl(Inline)]
        public Xmm(byte pos, Cell128 value)
        {
            Position = pos;
            Content = value;
        }

        public RegisterKind Kind
            => default(R).Kind;
    }
}