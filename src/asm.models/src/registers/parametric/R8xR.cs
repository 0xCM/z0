//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct R8<R> : IReg8<R8<R>,byte>
        where R : unmanaged, IRegister<R>
    {
        public readonly byte Data;

        [MethodImpl(Inline)]
        public R8(byte value)
        {
            Data = value;
        }

        public RegisterKind Kind
        {
            [MethodImpl(Inline)]
            get => default(R).Kind;
        }

        byte IAsmArg<byte>.Content
            => Data;
    }
}