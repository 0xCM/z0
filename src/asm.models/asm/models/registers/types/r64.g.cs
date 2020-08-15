//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct r64<R> : IRegOperand64<r64<R>,R>
        where R : unmanaged, IRegOperand64
    {
        public readonly ulong Data;

        [MethodImpl(Inline)]
        public r64(ulong value)
            => Data = value;

        public RegisterKind Kind 
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        ulong IOperand<ulong>.Content 
            => Data;
    }
}