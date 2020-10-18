//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct OutputValue<T> : ITextual
    {
        public readonly T Value;

        [MethodImpl(Inline)]
        public OutputValue(T src)
        {
            Value = src;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Value?.ToString() ?? EmptyString;

        public override string ToString()
                => Format();

        [MethodImpl(Inline)]
        public static implicit operator OutputValue<T>(T src)
            => new OutputValue<T>(src);
    }
}