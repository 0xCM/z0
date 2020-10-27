//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public readonly struct Json<T> : ITextual
    {
        public T Content {get;}

        [MethodImpl(Inline)]
        public Json(T src)
        {
            Content = src;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Json<T>(T src)
            => new Json<T>(src);
    }
}