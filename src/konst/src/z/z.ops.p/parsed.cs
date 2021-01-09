//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ParseResult<S,T> parsed<S,T>(S src, T value)
            => root.parsed(src, value);

        [MethodImpl(Inline)]
        public static ParseResult<T> parsed<T>(char src, T value)
            => root.parsed(src, value);

        [MethodImpl(Inline)]
        public static ParseResult<T> parsed<T>(object src, T value)
            => root.parsed(src, value);
    }
}