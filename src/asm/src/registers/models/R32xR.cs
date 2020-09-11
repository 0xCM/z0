//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R32<R> : IRegOperand32<R32<R>,R>
        where R : unmanaged, IRegOperand32
    {
        public readonly uint Data;

        [MethodImpl(Inline)]
        public R32(uint value)
            => Data = value;

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        uint IAsmArg<uint>.Content
            => Data;
    }
}