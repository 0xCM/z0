//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Struct)]
    public class SegmentedAttribute : WidthAttribute
    {
        public SegmentedAttribute(TypeWidth width, bool sequenced, params CellWidth[] widths)
            : base(width)
        {

        }
    }
}