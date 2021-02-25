//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct Tokens
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Token<K> token<K>(uint index, Identifier name, K kind, Name symbol)
            where K : unmanaged
                => new Token<K>(index,name,kind,symbol);
    }
}