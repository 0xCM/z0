//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct r8<R> : IRegOperand8<r8<R>,byte>
        where R : unmanaged, IRegOperand8
    {
        public readonly byte Data;

        [MethodImpl(Inline)]
        public r8(byte value)
        {
            Data = value;
        }

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        byte IOperand<byte>.Content
            => Data;
    }
}