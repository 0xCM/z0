//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmMem
    {
        public readonly struct mem<T> : IMemOp<T>
            where T : unmanaged, IMemOp
        {
            public T Content {get;}

            public AsmOpClass OpClass => AsmOpClass.M;

            [MethodImpl(Inline)]
            public mem(T src)
            {
                Content = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator mem<T>(T src)
                => new mem<T>(src);
        }
    }
}