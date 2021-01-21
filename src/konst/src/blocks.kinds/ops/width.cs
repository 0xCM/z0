//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class SegmentedKinds
    {
        public static TypeWidth width(Type src)
            => Widths.segmented(src);
    }
}