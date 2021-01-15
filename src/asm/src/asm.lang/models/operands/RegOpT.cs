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
        where T : unmanaged, IRegister
    {
        public byte Position {get;}

        public T Content {get;}

        [MethodImpl(Inline)]
        public RegOp(byte pos, T src)
        {
            Position = pos;
            Content = src;
        }

        public AsmOperandKind Kind => AsmOperandKind.R;

        [MethodImpl(Inline)]
        public RegOp<T> Reposition(byte pos)
            => new RegOp<T>(pos, Content);

        [MethodImpl(Inline)]
        public static implicit operator RegOp<T>(T src)
            => new RegOp<T>(0,src);
    }
}