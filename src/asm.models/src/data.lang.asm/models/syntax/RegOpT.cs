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
        public readonly struct RegOp<T> : IOperand<MemOp<T>,T>
            where T : unmanaged
        {
            public AsmOperandKind Kind => AsmOperandKind.R;

            public T Value {get;}

            [MethodImpl(Inline)]
            public RegOp(T src)
            {
                Value = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator RegOp<T>(T src)
                => new RegOp<T>(src);
        }
    }
}