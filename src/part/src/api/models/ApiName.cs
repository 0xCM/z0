//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiName : ITextual
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator ApiName<string>(ApiName src)
            => new ApiName<string>(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator ApiName(string src)
            => new ApiName(src);

        [MethodImpl(Inline)]
        public ApiName(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();
    }
}