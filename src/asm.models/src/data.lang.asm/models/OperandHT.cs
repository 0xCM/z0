//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct AsmLang
    {
        [StructLayout(LayoutKind.Sequential)]
        public readonly struct Operand<T> : IOperand<Operand<T>,T>
            where T : unmanaged, IOperand<T>
        {
            public AsmOperandKind Kind => Value.Kind;

            public T Value {get;}

            [MethodImpl(Inline)]
            public Operand(T value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator Operand<T>(T src)
                => new Operand<T>(src);
        }
    }
}