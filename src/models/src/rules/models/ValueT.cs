//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Rules;

    partial struct Rules
    {
        public readonly struct Value<T> : IValue<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public Value(T value)
            {
                Content = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator Value<T>(T src)
                => new Value<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator T(Value<T> src)
                => src.Content;
            public string Format()
                => Content.ToString();

            public override string ToString()
                => Format();
        }
    }
}