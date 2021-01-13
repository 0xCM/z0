//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOperand<T> : IAsmOperand<T>
        where T : unmanaged, IAsmOperand<T>
    {
        public T Content {get;}

        public AsmOperandKind Kind => Content.Kind;

        [MethodImpl(Inline)]
        public AsmOperand(T value)
            => Content = value;

        [MethodImpl(Inline)]
        public static implicit operator AsmOperand<T>(T src)
            => new AsmOperand<T>(src);
    }
}