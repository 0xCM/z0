//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Label<T>
    {
        public Identifier Name {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public Label(Identifier name, T src)
        {
            Name = name;
            Value = src;
        }

        public string Format()
            => Value?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();
    }
}