//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Zmm<R> : IRegister<Zmm<R>,W512,Cell512>, IAsmOperand<RegisterKind, Cell512>
        where R : unmanaged, IRegister
    {
        public Cell512 Content {get;}

        [MethodImpl(Inline)]
        public Zmm(Cell512 value)
        {
            Content = value;
        }

        public RegisterKind Kind
            => default(R).Kind;
    }
}