//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    public readonly struct xmm<R> : IXmmRegOp<xmm<R>,R>
        where R : unmanaged, IRegOp
    {
        public Fixed128 Content {get;}

        [MethodImpl(Inline)]
        public xmm(Fixed128 value)
        {
            Content = value;
        }

        public RegisterKind Kind 
            => default;

    }
}