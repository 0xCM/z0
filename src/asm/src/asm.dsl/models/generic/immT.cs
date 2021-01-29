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
        public readonly struct imm<T> : IAsmOperand<T>
            where T : unmanaged
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public imm(T src)
            {
                Content = src;
            }

            public AsmOperandClass Kind => AsmOperandClass.Imm;

            [MethodImpl(Inline)]
            public static implicit operator imm<T>(T src)
                => new imm<T>(src);
        }
    }
}