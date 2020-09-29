//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R32<R> : IRegister<R32<R>,W32,uint>
        where R : unmanaged, IRegister
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public R32(uint value)
            => Content = value;

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }
    }
}