//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOps
    {
        public readonly struct imm<T> : IImmOp<T>
            where T : unmanaged
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public imm(T src)
            {
                Content = src;
            }

            public AsmOpClass OpClass => AsmOpClass.Imm;

            [MethodImpl(Inline)]
            public static implicit operator imm<T>(T src)
                => new imm<T>(src);
        }
    }
}