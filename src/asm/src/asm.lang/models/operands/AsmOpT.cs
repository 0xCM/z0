//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an asm operand
    /// </summary>
    public readonly struct AsmOp<T> : IAsmOperand<T>
        where T : unmanaged, IAsmOperand<T>
    {
        public byte Position {get;}

        public T Content {get;}

        public AsmOperandKind Kind => Content.Kind;

        [MethodImpl(Inline)]
        public AsmOp(byte pos, T value)
        {
            Position = pos;
            Content = value;
        }

        [MethodImpl(Inline)]
        public AsmOp<T> Reposition(byte pos)
            => new AsmOp<T>(pos, Content);

        [MethodImpl(Inline)]
        public static implicit operator AsmOp<T>(T src)
            => new AsmOp<T>(0,src);
    }
}