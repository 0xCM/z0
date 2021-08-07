//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        public readonly struct CountRule
        {
            public Identifier Name {get;}

            public Count Value {get;}

            [MethodImpl(Inline)]
            public CountRule(Identifier name, Count value)
            {
                Name = name;
                Value = value;
            }

            public string Format()
                => string.Format("{0}:{1}", Name,Value);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator CountRule((string name, Count value) src)
                => new CountRule(src.name, src.value);
        }
    }
}