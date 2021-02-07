//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public static partial class XBitSpans
    {
        [MethodImpl(Inline)]
        public static string Format(this BitSpan src, BitFormat? fmt = null)
            => BitSpans.format(src, fmt);
    }
}