//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static BitSpan load(Span<bit> src)
            => new BitSpan(src);
    }
}