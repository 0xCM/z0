//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiUri<T> : ITextual
    {
        public readonly T Representation;

        [MethodImpl(Inline)]
        public ApiUri(T rep)
        {
            Representation = rep;
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiUri<T>(T src)
            => new ApiUri<T>(src);

        [MethodImpl(Inline)]
        public string Format()
            => Representation?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();
    }
}