//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DirectiveOp
    {
        public ulong Value {get;}

        [MethodImpl(Inline)]
        public DirectiveOp(ulong value)
        {
            Value = value;
        }

        public string Format()
            => Value.FormatHex();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DirectiveOp(ulong src)
            => new DirectiveOp(src);
    }
}