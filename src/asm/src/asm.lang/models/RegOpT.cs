//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RegOp<T> : IAsmOperand<T>
        where T : unmanaged
    {
        public AsmOperandKind Kind => AsmOperandKind.R;

        public T Content {get;}

        [MethodImpl(Inline)]
        public RegOp(T src)
        {
            Content = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator RegOp<T>(T src)
            => new RegOp<T>(src);
    }
}