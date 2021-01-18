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
        public byte Position {get;}

        public T Content {get;}

        [MethodImpl(Inline)]
        public ImmOp(byte pos, T src)
        {
            Position = pos;
            Content = src;
        }

        public AsmOperandKind Kind => AsmOperandKind.Imm;

        [MethodImpl(Inline)]
        public ImmOp<T> Reposition(byte pos)
            => new ImmOp<T>(pos, Content);

        [MethodImpl(Inline)]
        public static implicit operator ImmOp<T>(T src)
            => new ImmOp<T>(0,src);
    }
}