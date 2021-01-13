//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ImmOp<T> : IAsmOperand<T>
        where T : unmanaged
    {
        public AsmOperandKind Kind => AsmOperandKind.Imm;

        public T Content {get;}

        [MethodImpl(Inline)]
        public ImmOp(T src)
        {
            Content = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator ImmOp<T>(T src)
            => new ImmOp<T>(src);
    }
}