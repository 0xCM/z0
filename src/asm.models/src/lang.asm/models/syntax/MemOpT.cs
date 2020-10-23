//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using OK = AsmOperandKind;

    partial struct AsmLang
    {
        public readonly struct MemOp<T> : IOperand<MemOp<T>,T>
            where T : unmanaged
        {
            public AsmOperandKind Kind => AsmOperandKind.M;

            public T Value {get;}

            [MethodImpl(Inline)]
            public MemOp(T src)
            {
                Value = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator MemOp<T>(T src)
                => new MemOp<T>(src);
        }
    }
}