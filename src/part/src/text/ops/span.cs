//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> span(string src)
            => src;
    }
}