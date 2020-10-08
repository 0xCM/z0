//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Struct)]
    public class SegmentedAttribute : WidthAttribute
    {
        public SegmentedAttribute(TypeWidth width, bool sequenced, params CellWidth[] widths)
            : base(width)
        {

        }
    }

}