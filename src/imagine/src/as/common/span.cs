//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsDeprecated
    {
        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> span(string src)
            => src;
    }
}