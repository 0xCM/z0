//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct AsmLang
    {
        [StructLayout(LayoutKind.Sequential)]
        public readonly struct Operand<T> : IAsmOperand<T>
            where T : unmanaged, IAsmOperand<T>
        {
            public AsmOperandKind Kind => Content.Kind;

            public T Content {get;}

            [MethodImpl(Inline)]
            public Operand(T value)
                => Content = value;

            [MethodImpl(Inline)]
            public static implicit operator Operand<T>(T src)
                => new Operand<T>(src);
        }
    }
}