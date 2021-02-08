//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmRegs
    {
        public readonly struct reg<T> : IRegOp<T>
            where T : unmanaged, IRegister
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public reg(T src)
            {
                Content = src;
            }

            [MethodImpl(Inline)]
            public reg<T> Reposition(byte pos)
                => new reg<T>(Content);

            [MethodImpl(Inline)]
            public static implicit operator reg<T>(T src)
                => new reg<T>(src);
        }
    }
}