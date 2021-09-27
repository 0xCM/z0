//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct DirectiveOperand
    {
        public string Value {get;}

        [MethodImpl(Inline)]
        public DirectiveOperand(string value)
        {
            Value = value;
        }

        public string Format()
            => Value ?? EmptyString;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DirectiveOperand(string src)
            => new DirectiveOperand(src);
    }
}