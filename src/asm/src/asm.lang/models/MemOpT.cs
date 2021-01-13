//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MemOp<T> : IAsmOperand<T>
        where T : unmanaged
    {
        public T Content {get;}

        public AsmOperandKind Kind => AsmOperandKind.M;

        [MethodImpl(Inline)]
        public MemOp(T src)
            => Content = src;

        [MethodImpl(Inline)]
        public static implicit operator MemOp<T>(T src)
            => new MemOp<T>(src);
    }
}