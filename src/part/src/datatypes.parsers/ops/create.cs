//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Parsers
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Parser<T> create<T>(ParseFunction<T> f)
            => new Parser<T>(f);

        [MethodImpl(Inline)]
        public static Parser<T,K> create<T,K>(ParseFunction<T> f, K kind)
            where K : unmanaged
                => new Parser<T,K>(f,kind);
    }
}