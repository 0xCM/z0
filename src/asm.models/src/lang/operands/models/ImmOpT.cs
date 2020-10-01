//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        public readonly struct ImmOp<T> : IOperand<MemOp<T>,T>
            where T : unmanaged
        {
            public AsmOperandKind Kind => AsmOperandKind.Imm;

            public T Value {get;}

            [MethodImpl(Inline)]
            public ImmOp(T src)
            {
                Value = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator ImmOp<T>(T src)
                => new ImmOp<T>(src);
        }
    }
}