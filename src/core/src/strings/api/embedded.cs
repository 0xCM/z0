//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Strings;

    using static Root;

    partial struct strings
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EmbeddedWord<S> embedded<S>(ReadOnlySpan<S> src)
            where S : unmanaged
                => new EmbeddedWord<S>(src);

        [MethodImpl(Inline), Op]
        public static EmbeddedWord<char> embedded(string src)
            => new EmbeddedWord<char>(src);

        [MethodImpl(Inline), Op]
        public static EmbeddedWord<char> embedded(ReadOnlySpan<char> src)
            => new EmbeddedWord<char>(src);
    }
}