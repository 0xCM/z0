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

    public readonly struct ymm<R> : IYmmRegOperand<ymm<R>,R>
        where R : unmanaged, IRegOperand
    {
        public Fixed256 Content {get;}

        [MethodImpl(Inline)]
        public ymm(Fixed256 value)
        {
            Content = value;
        }

        public RegisterKind Kind 
            => default;
    }
}