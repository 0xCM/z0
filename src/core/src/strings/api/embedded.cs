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
        public static WordRefs<S> embedded<S>(ReadOnlySpan<S> src)
            where S : unmanaged
                => new WordRefs<S>(src);

        [MethodImpl(Inline), Op]
        public static WordRefs<char> embedded(string src)
            => new WordRefs<char>(src);

        [MethodImpl(Inline), Op]
        public static WordRefs<char> embedded(ReadOnlySpan<char> src)
            => new WordRefs<char>(src);
    }
}