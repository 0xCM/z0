//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDsl
    {
        public readonly struct MemOp<T> : IMemOp<T>
            where T : unmanaged, IMemOp
        {
            public T Content {get;}

            public AsmOpClass OpClass => AsmOpClass.M;

            [MethodImpl(Inline)]
            public MemOp(T src)
            {
                Content = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator MemOp<T>(T src)
                => new MemOp<T>(src);
        }
    }
}