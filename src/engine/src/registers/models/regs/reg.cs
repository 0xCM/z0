//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Regs
    {
        public readonly struct reg<T>
            where T : unmanaged, IReg
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public reg(T src)
                => Content = src;

            [MethodImpl(Inline)]
            public reg<T> Reposition(byte pos)
                => new reg<T>(Content);

            [MethodImpl(Inline)]
            public static implicit operator reg<T>(T src)
                => new reg<T>(src);
        }
    }
}