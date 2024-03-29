//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmDirectiveOp<T>
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public AsmDirectiveOp(T value)
        {
            Value = value;
        }

        public string Format()
            => Value.ToString();

        [MethodImpl(Inline)]
        public static implicit operator AsmDirectiveOp<T>(T src)
            => new AsmDirectiveOp<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmDirectiveOp(AsmDirectiveOp<T> src)
            => new AsmDirectiveOp(src.Format());
    }
}
