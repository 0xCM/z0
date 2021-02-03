//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Value
    {
        public DataType Type {get;}

        public dynamic Content {get;}

        [MethodImpl(Inline)]
        public Value(DataType type, dynamic content)
        {
            Type = type;
            Content = content;
        }
    }

    public readonly struct Value<T> : IValue<T>
    {
        public DataType Type {get;}

        public T Content {get;}

        [MethodImpl(Inline)]
        public Value(DataType type, T content)
        {
            Type = type;
            Content = content;
        }

        public static implicit operator Value(Value<T> src)
            => new Value(src.Type, src.Content);
    }
}