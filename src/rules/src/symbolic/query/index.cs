//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<char> src, ReadOnlySpan<char> match)
            => src.IndexOf(match);

        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<char> src, char match)
            => src.IndexOf(match);
    }
}