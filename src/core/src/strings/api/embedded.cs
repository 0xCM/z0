//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct strings
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EmbeddedString<S> embedded<S>(ReadOnlySpan<S> src)
            where S : unmanaged
                => new EmbeddedString<S>(src);

        [MethodImpl(Inline), Op]
        public static EmbeddedString<char> embedded(string src)
            => new EmbeddedString<char>(src);

        [MethodImpl(Inline), Op]
        public static EmbeddedString<char> embedded(ReadOnlySpan<char> src)
            => new EmbeddedString<char>(src);
    }
}