//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public class FixedAttribute : SegmentedAttribute
    {
        public FixedAttribute(object totalwidth, bool sequenced, params object[] segwidths)
            : base(totalwidth, sequenced, segwidths)
        {
        }
    }
}