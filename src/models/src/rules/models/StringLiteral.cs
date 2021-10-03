//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct StringLiteral
        {
            public Label Name {get;}

            public Constant<string> Value {get;}

            [MethodImpl(Inline)]
            public StringLiteral(Label name, string value)
            {
                Name = name;
                Value = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator StringLiteral((Label name, string value) src)
                => new StringLiteral(src.name,src.value);

            public string Format()
                => string.Format("{0} := {1}", Name, Value);

            public override string ToString()
                => Format();
        }
    }
}