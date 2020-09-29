//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R64<R> : IRegister<R64<R>,W64,ulong>
        where R : unmanaged, IRegister
    {
        public ulong Content {get;}

        [MethodImpl(Inline)]
        public R64(ulong value)
            => Content = value;

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }
    }
}