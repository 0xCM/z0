//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R64<R> : IRegOperand64<R64<R>,R>
        where R : unmanaged, IRegOperand64
    {
        public readonly ulong Data;

        [MethodImpl(Inline)]
        public R64(ulong value)
            => Data = value;

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        ulong IAsmArg<ulong>.Content
            => Data;
    }
}