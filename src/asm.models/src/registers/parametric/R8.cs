//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R8<R> : IRegister<R8<R>,W8,byte>
        where R : unmanaged, IRegister
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public R8(byte value)
            => Content = value;

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }
    }
}