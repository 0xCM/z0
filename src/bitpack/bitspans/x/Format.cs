//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static string Format(this BitSpan src, BitFormat? fmt = null)
            => BitSpans.format(src, fmt);
    }
}