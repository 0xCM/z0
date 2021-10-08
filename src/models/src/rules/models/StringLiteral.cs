//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct StringLiteral : ITerm
    {
        public Label Name {get;}

        public Constant<string> Value {get;}

        [MethodImpl(Inline)]
        public StringLiteral(Label name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator StringLiteral((Label name, string value) src)
            => new StringLiteral(src.name,src.value);
    }
}