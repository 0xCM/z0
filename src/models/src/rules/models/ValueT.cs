//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = api;

    partial struct api
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