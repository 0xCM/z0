//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DirectiveOperand<T>
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public DirectiveOperand(T value)
        {
            Value = value;
        }

        public string Format()
            => Value.ToString();

        [MethodImpl(Inline)]
        public static implicit operator DirectiveOperand<T>(T src)
            => new DirectiveOperand<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator DirectiveOperand(DirectiveOperand<T> src)
            => new DirectiveOperand(src.Format());
    }
}
